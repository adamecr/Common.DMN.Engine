using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using net.adamec.lib.common.core.logging;

namespace net.adamec.lib.common.dmn.engine.parser
{
    /// <summary>
    /// S-FEEL simple parser
    /// </summary>
    public class SfeelParser
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<SfeelParser>();

        /// <summary>
        /// Custom functions to be  used in DynamoExpression for S-FEEL functions
        /// </summary>
        public static Dictionary<string, Delegate> CustomFunctions { get; } = new Dictionary<string, Delegate>();
        /// <summary>
        /// Translations of custom functions from  S-FEEL to <see cref="CustomFunctions"/>
        /// For example "date and time" will be "date_and_time"
        /// </summary>
        private static Dictionary<string, string> CustomFunctionTranslations { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Initialize <see cref="SfeelParser"/>.
        /// Defines the <see cref="CustomFunctions"/> for the DynamoExpression interpreter
        /// </summary>
        static SfeelParser()
        {
            PrepareCustomFunctions();
        }

        /// <summary>
        /// Parses the S-FEEL expression and creates the comparison that will be used in rule evaluation
        /// The parser recognize the basic types of S-FEEL expressions: not(expr), simple comparators, multiple values and range
        /// </summary>
        /// <param name="expr">Source expression</param>
        /// <param name="leftSide">Left side of comparison expression - to what to compare to</param>
        /// <returns>Expression to be used in rule evaluation</returns>
        /// <exception cref="DmnParserException">Missing expression (<paramref name="expr"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">Missing left side of expression (<paramref name="leftSide"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">Wrong S-FEEL range</exception>
        public static string ParseInput(string expr, string leftSide)
        {
            if (string.IsNullOrWhiteSpace(expr)) throw Logger.Error<DmnParserException>($"Missing expression");
            if (string.IsNullOrWhiteSpace(leftSide)) throw Logger.Error<DmnParserException>($"Missing left side of expression");

            if (Logger.IsTraceEnabled)
                Logger.Trace($"Parsing input expression {expr} for left side {leftSide}...");
            expr = expr.Trim();
            //custom functions translations
            foreach (var translation in CustomFunctionTranslations)
            {
                expr = expr.Replace(translation.Key, translation.Value);
            }
            //check not(expr)
            var isNegated = false;
            if (expr.StartsWith("not(") && expr.EndsWith(")"))
            {
                expr = expr.Substring(4, expr.Length - 5);
                isNegated = true;
            }
            //split to parts
            var exprParts = Regex.Split(expr, @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
            var conditionParts = new List<string>();
            foreach (var exprPart in exprParts)
            {
                var part = exprPart.Trim();

                //<,<=,>=,>
                if (part.StartsWith("<") || part.StartsWith(">"))
                {
                    conditionParts.Add($"{leftSide}{part}");
                    continue;
                }

                //[xx..yy] (] )[
                if ((part.StartsWith("[") || part.StartsWith("]") || part.StartsWith("(")) &&
                    (part.EndsWith("]") || part.EndsWith("[") || part.EndsWith(")")))
                {
                    var partInner = part.Substring(1, part.Length - 2);
                    var partInnerSplit = partInner.Split(new[] { ".." }, StringSplitOptions.None);
                    // ReSharper disable once InvertIf
                    if (partInnerSplit.Length == 2)
                    {
                        var compLeft = part.StartsWith("[") ? ">=" : ">";
                        var compRight = part.EndsWith("]") ? "<=" : "<";
                        conditionParts.Add($"({leftSide}{compLeft}{partInnerSplit[0].Trim()} && {leftSide}{compRight}{partInnerSplit[1].Trim()})");
                        continue;
                    }

                    throw Logger.Error<DmnParserException>($"Wrong S-FEEL range {part}");
                }

                // string in "" "", number,variable name, .. - compare for eq
                conditionParts.Add($"{leftSide}=={part}");
            }

            var condition = string.Join(" || ", conditionParts);
            if (isNegated) condition = $"!({condition})";
            if (Logger.IsTraceEnabled)
                Logger.Trace($"Parsed input expression {expr} for variable {leftSide} - {condition}");
            return condition;
        }

        /// <summary>
        /// Defines the <see cref="CustomFunctions"/> for the DynamoExpression interpreter.
        /// </summary>
        public static void PrepareCustomFunctions()
        {
            //date("2012-12-25") 
            var dateFormats = new[] { "yyyy-MM-dd" };
            Func<string, DateTime> date = (s) => XmlConvert.ToDateTime(s, dateFormats);
            CustomFunctions.Add("date", date);

            //date and time("2012-12- 24T23:59:00") 
            var dateAndTimeFormats = new[] { "yyyy-MM-ddTHH:mm:sszzzzzz", "yyyy-MM-ddTHH:mm:ss", "yyyy-MM-ddTHH:mm" };
            Func<string, DateTime> dateAndTime = (s) => XmlConvert.ToDateTime(s, dateAndTimeFormats);
            CustomFunctions.Add("date_and_time", dateAndTime);
            CustomFunctionTranslations.Add("date and time", "date_and_time");

            //time("23:59:00") 
            var timeFormats = new[] { "HH:mm:sszzzzzz", "HH:mm:ss", "HH:mm" };
            Func<string, DateTime> time = (s) => XmlConvert.ToDateTime(s, timeFormats);
            CustomFunctions.Add("time", time);

            //duration("P3Y")
            Func<string, TimeSpan> duration = XmlConvert.ToTimeSpan;
            CustomFunctions.Add("duration", duration);
        }
    }
}
