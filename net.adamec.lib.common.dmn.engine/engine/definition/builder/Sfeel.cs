using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Helper struct for composing the SFeel input expressions
    /// </summary>
    /// <remarks>The struct helps with the syntax, but don't check for semantics, so it's necessary to understand how to compose the valid expressions</remarks>
    public readonly struct SFeel
    {
        /// <summary>
        /// String expression represented by <see cref="SFeel"/>
        /// </summary>
        private readonly string expression;

        /// <summary>
        /// Helper struct for composing the SFeel input expression tokens - the single "constant" or variable
        /// </summary>
        public readonly struct Token
        {
            /// <summary>
            /// String representation of the <see cref="Token"/>
            /// </summary>
            private readonly string value;

            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="t">Existing token to clone</param>
            private Token(Token t)
            {
                value = t.value;
            }

            /// <summary>
            /// CTOR - creates a new <see cref="Token"/> based on expression representation (<paramref name="isValue"/> is true) or string constant
            /// </summary>
            /// <param name="s">String constant (<paramref name="isValue"/> is true) or expression</param>
            /// <param name="isValue">Flag whether <param name="s"> represents the expression (value) or string constant</param></param>
            internal Token(string s, bool isValue = false)
            {
                if (s is null) throw new ArgumentNullException(nameof(s));
                if (string.IsNullOrWhiteSpace(s)) throw new ArgumentException("Missing token value", nameof(s));

                value = isValue ? s : $"\"{s}\"";
            }

            /// <summary>
            /// CTOR - create a new token representing a string constant
            /// </summary>
            /// <param name="s">String constant</param>
            public Token(string s) : this(s, false)
            {
            }

            /// <summary>
            /// CTOR - create a new token representing an integer constant
            /// </summary>
            /// <param name="i">Integer constant</param>
            public Token(int i)
            {
                value = $"{i}";
            }

            /// <summary>
            /// CTOR - create a new token representing a bool constant
            /// </summary>
            /// <param name="b">Bool constant</param>
            public Token(bool b)
            {
                value = b ? "true" : "false";
            }

            /// <summary>
            /// CTOR - create a new token representing a reference to variable
            /// </summary>
            /// <param name="variableRef">Reference to existing variable</param>
            public Token(Variable.Ref variableRef)
            {
                if (variableRef is null) throw new ArgumentNullException(nameof(variableRef));
                value = variableRef.Name;
            }

            /// <summary>
            /// CTOR - create a new token representing set of tokens ("list of constants/variables")
            /// </summary>
            /// <param name="tokens">Tokens ("list of constants/variables") to put into the set</param>
            public Token(params Token[] tokens)
            {
                if (tokens is null) throw new ArgumentNullException(nameof(tokens));
                if (tokens.Length == 0) throw new ArgumentException("Missing tokens", nameof(tokens));

                var aggregate = new Token(tokens[0]);
                aggregate = tokens.Skip(1).Aggregate(aggregate, (current, token) => current + token);

                value = aggregate.value;
            }

            /// <summary>
            /// Implicit conversion of <see cref="Token"/> to <see cref="string"/>
            /// </summary>
            /// <param name="t">Token to convert to string (expression)</param>
            public static implicit operator string(Token t) => t.ToString();

            /// <summary>
            /// Implicit conversion from <see cref="string"/> - creates a token representing a string constant
            /// </summary>
            /// <param name="s">String constant</param>
            public static implicit operator Token(string s) => new Token(s);
            /// <summary>
            /// Implicit conversion from <see cref="int"/> - creates a token representing an int constant
            /// </summary>
            /// <param name="i">Integer constant</param>
            public static implicit operator Token(int i) => new Token(i);
            /// <summary>
            /// Implicit conversion from <see cref="bool"/> - creates a token representing a bool constant
            /// </summary>
            /// <param name="b">Bool constant</param>
            public static implicit operator Token(bool b) => new Token(b);
            /// <summary>
            /// Implicit conversion from <see cref="Variable.Ref "/> - creates a token representing a reference to variable
            /// </summary>
            /// <param name="variableRef">Reference to existing variable</param>
            public static implicit operator Token(Variable.Ref variableRef) => new Token(variableRef);

            /// <summary>
            /// Implicit "+" operator - creates a new set of constants/variables from <paramref name="token1"/> and <paramref name="token2"/>
            /// </summary>
            /// <remarks>The tokens can be either single constant/variable or already existing set</remarks>
            /// <param name="token1">The first token to add to a new set</param>
            /// <param name="token2">The second token to add to a new set</param>
            public static Token operator +(Token token1, Token token2)
            {
                return new Token($"{token1},{token2}", true);
            }

            /// <inheritdoc />
            /// <summary>Returns a string that represents the current object.</summary>
            /// <returns>A string that represents the current object.</returns>
            [ExcludeFromCodeCoverage]
            public override string ToString() => value ?? string.Empty;
        }

        /// <summary>
        /// CTOR - creates an expression from <see cref="Token"/>
        /// </summary>
        /// <param name="t">Token to create an expression from</param>
        private SFeel(Token t)
        {
            expression = t.ToString();
        }

        /// <summary>
        /// Implicit conversion of <see cref="Token"/> to <see cref="string"/>
        /// </summary>
        /// <param name="e">Expression representation to convert to string (expression)</param>
        public static implicit operator string(SFeel e) => e.ToString();
        /// <summary>
        /// Implicit conversion of <see cref="Token"/> to <see cref="SFeel"/> expression
        /// </summary>
        /// <param name="t">Token to convert to SFeel expression</param>
        public static implicit operator SFeel(Token t) => new SFeel(t);

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString() => expression ?? string.Empty;

        /// <summary>
        /// Creates a <code>not</code> SFeel expression encapsulating an existing <see cref="SFeel"/> expression
        /// </summary>
        /// <param name="e"><see cref="SFeel"/> expression to negate</param>
        public static string Not(SFeel e) => $"not({e})";
        /// <summary>
        /// Creates a <code>not</code> SFeel expression encapsulating an existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/> to negate</param>
        public static string Not(Token t) => $"not({t})";
        /// <summary>
        /// Creates a <code>not</code> SFeel expression encapsulating an expression string
        /// </summary>
        /// <param name="s">Expression to negate</param>
        public static string Not(string s) => $"not({s})";
        /// <summary>
        /// Creates a <code>not</code> SFeel expression encapsulating an existing expression <see cref="Token"/> set
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/>set to negate</param>
        public static string Not(params Token[] t) => $"not({new Token(t)})";

        /// <summary>
        /// Creates an equality expression from existing <see cref="SFeel"/> expression
        /// </summary>
        /// <param name="e"><see cref="SFeel"/> expression</param>
        public static string Eq(SFeel e) => e; //Eq (==) is default operator
        /// <summary>
        /// Creates an equality expression from existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/></param>
        public static string Eq(Token t) => t;
        public static string Eq(params Token[] t) => new Token(t);

        /// <summary>
        /// Creates an inequality expression from existing <see cref="SFeel"/> expression
        /// </summary>
        /// <param name="e"><see cref="SFeel"/> expression</param>
        public static string Ne(SFeel e) => Not(e);
        /// <summary>
        /// Creates an inequality expression from existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/></param>
        public static string Ne(Token t) => Not(t);
        public static string Ne(params Token[] t) => Not(new Token(t));

        /// <summary>
        /// Creates a greater-than expression from existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/></param>
        public static string Gt(Token t) => $"> {t}";
        /// <summary>
        /// Creates a greater-or-equal expression from existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/></param>
        public static string Ge(Token t) => $">= {t}";
        /// <summary>
        /// Creates a less-than expression from existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/></param>
        public static string Lt(Token t) => $"< {t}";
        /// <summary>
        /// Creates a less-or-equal expression from existing expression <see cref="Token"/>
        /// </summary>
        /// <param name="t">Expression <see cref="Token"/></param>
        public static string Le(Token t) => $"<= {t}";

        /// <summary>
        /// Creates an expression token representing the range of values
        /// </summary>
        /// <param name="from">Range opening value</param>
        /// <param name="to">Range closing value</param>
        /// <param name="fromInclusive">Flag whether the <paramref name="from"/> value is to be included within the range</param>
        /// <param name="toInclusive">Flag whether the <paramref name="to"/> value is to be included within the range</param>
        private static Token Rng(int from, int to, bool fromInclusive = true, bool toInclusive = true)
        {
            return new Token($"{(fromInclusive ? "[" : "]")}{from}..{to}{(toInclusive ? "]" : "[")}", true);
        }

        // ReSharper disable InconsistentNaming
        // ReSharper disable RedundantArgumentDefaultValue
        /// <summary>
        /// Creates an expression token representing the range of values (<code>[from..to]</code>)
        /// </summary>
        /// <param name="from">Range opening value (including)</param>
        /// <param name="to">Range closing value (including)</param>
        public static Token RngI(int from, int to) => Rng(from, to, true, true);
        /// <summary>
        /// Creates an expression token representing the range of values (<code>]from..to[</code>)
        /// </summary>
        /// <param name="from">Range opening value (excluding)</param>
        /// <param name="to">Range closing value (excluding)</param>
        public static Token RngE(int from, int to) => Rng(from, to, false, false);
        /// <summary>
        /// Creates an expression token representing the range of values (<code>[from..to[</code>)
        /// </summary>
        /// <param name="from">Range opening value (including)</param>
        /// <param name="to">Range closing value (excluding)</param>
        public static Token RngIE(int from, int to) => Rng(from, to, true, false);
        /// <summary>
        /// Creates an expression token representing the range of values (<code>]from..to]</code>)
        /// </summary>
        /// <param name="from">Range opening value (excluding)</param>
        /// <param name="to">Range closing value (including)</param>
        public static Token RngEI(int from, int to) => Rng(from, to, false, true);
        // ReSharper restore RedundantArgumentDefaultValue
        // ReSharper restore InconsistentNaming

        /// <summary>
        /// Creates an expression token representing SFeel <code>date</code> function
        /// </summary>
        /// <param name="s">String representing the date in <code>YYYY-MM-DD</code> format</param>
        public static Token Date(string s) => new Token($"date(\"{s}\")", true);
        /// <summary>
        /// Creates an expression token representing SFeel <code>date</code> function
        /// </summary>
        /// <param name="dt"><see cref="DateTime"/> to create an SFeel <code>date</code> function from</param>
        public static Token Date(DateTime dt) => Date(DateStr(dt.Year, dt.Month, dt.Day));
        /// <summary>
        /// Creates an expression token representing SFeel <code>date</code> function
        /// </summary>
        /// <param name="year">Years part</param>
        /// <param name="month">Months part</param>
        /// <param name="day">Days part</param>
        public static Token Date(int year, int month, int day) => Date(DateStr(year, month, day));

        /// <summary>
        /// Creates an expression token representing SFeel <code>date and time</code> function
        /// </summary>
        /// <param name="s">String representing the date and time in <code>YYYY-MM-DDTHHmmSS</code>,
        /// <code>YYYY-MM-DDTHHmm</code> or <code>YYYY-MM-DD</code> format</param>
        public static Token DateAndTime(string s) => new Token($"date and time(\"{s}\")", true);
        /// <summary>
        /// Creates an expression token representing SFeel <code>date and time</code> function
        /// </summary>
        /// <remarks>If all time parts are 0 the time part is not generated</remarks>
        /// <param name="dt"><see cref="DateTime"/> to create an SFeel <code>date and time</code> function from</param>
        public static Token DateAndTime(DateTime dt) => DateAndTime(DateTimeStr(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second));
        /// <summary>
        /// Creates an expression token representing SFeel <code>date and time</code> function
        /// </summary>
        /// <remarks>If all time parts are 0 the time part is not generated</remarks>
        /// <param name="year">Years part</param>
        /// <param name="month">Months part</param>
        /// <param name="day">Days part</param>
        /// <param name="hour">Hours part</param>
        /// <param name="minute">Minutes part</param>
        public static Token DateAndTime(int year, int month, int day, int hour, int minute) => DateAndTime(DateTimeStr(year, month, day, hour, minute, 0));
        /// <summary>
        /// Creates an expression token representing SFeel <code>date and time</code> function
        /// </summary>
        /// <remarks>If all time parts are 0 the time part is not generated</remarks>
        /// <param name="year">Years part</param>
        /// <param name="month">Months part</param>
        /// <param name="day">Days part</param>
        /// <param name="hour">Hours part</param>
        /// <param name="minute">Minutes part</param>
        /// <param name="second">Seconds part or 0 to skip</param>
        public static Token DateAndTime(int year, int month, int day, int hour, int minute, int second) => DateAndTime(DateTimeStr(year, month, day, hour, minute, second));

        /// <summary>
        /// Creates an expression token representing SFeel <code>time</code> function
        /// </summary>
        /// <param name="s">String representing the time in <code>HHmmSS</code> format or <code>HHmm</code> format </param>
        public static Token Time(string s) => new Token($"time(\"{s}\")", true);
        /// <summary>
        /// Creates an expression token representing SFeel <code>time</code> function
        /// </summary>
        /// <param name="ts"><see cref="TimeSpan"/> to create an SFeel <code>time</code> function from</param>
        public static Token Time(TimeSpan ts) => Time(TimeStr(ts.Hours, ts.Minutes, ts.Seconds));
        /// <summary>
        /// Creates an expression token representing SFeel <code>time</code> function
        /// </summary>
        /// <param name="hour">Hours part</param>
        /// <param name="minute">Minutes part</param>
        public static Token Time(int hour, int minute) => Time(TimeStr(hour, minute, 0));
        /// <summary>
        /// Creates an expression token representing SFeel <code>time</code> function
        /// </summary>
        /// <param name="hour">Hours part</param>
        /// <param name="minute">Minutes part</param>
        /// <param name="second">Seconds part or 0 to skip</param>
        public static Token Time(int hour, int minute, int second) => Time(TimeStr(hour, minute, second));

        /// <summary>
        /// Creates an expression token representing SFeel <code>duration</code> function
        /// </summary>
        /// <param name="s">String representing the duration in XML (ISO 8601) format</param>
        public static Token Duration(string s) => new Token($"duration(\"{s}\")", true);
        /// <summary>
        /// Creates an expression token representing SFeel <code>duration</code> function
        /// </summary>
        /// <param name="ts"><see cref="TimeSpan"/> to create an SFeel <code>duration</code> function from</param>
        public static Token Duration(TimeSpan ts) => Duration(XmlConvert.ToString(ts));
        /// <summary>
        /// Creates an expression token representing SFeel <code>duration</code> function
        /// </summary>
        /// <param name="days">Days part or 0 to skip</param>
        /// <param name="hours">Hours part or 0 to skip</param>
        /// <param name="minutes">Minutes part or 0 to skip</param>
        /// <param name="negative">Flag whether the duration is negative</param>
        public static Token Duration(int days, int hours, int minutes, bool negative = false) => Duration(DurationStr(0, 0, days, hours, minutes, 0, negative));
        /// <summary>
        /// Creates an expression token representing SFeel <code>duration</code> function
        /// </summary>
        /// <param name="years">Years part or 0 to skip</param>
        /// <param name="months">Months part or 0 to skip</param>
        /// <param name="days">Days part or 0 to skip</param>
        /// <param name="hours">Hours part or 0 to skip</param>
        /// <param name="minutes">Minutes part or 0 to skip</param>
        /// <param name="negative">Flag whether the duration is negative</param>
        public static Token Duration(int years, int months, int days, int hours, int minutes, bool negative = false) => Duration(DurationStr(years, months, days, hours, minutes, 0, negative));
        /// <summary>
        /// Creates an expression token representing SFeel <code>duration</code> function
        /// </summary>
        /// <param name="years">Years part or 0 to skip</param>
        /// <param name="months">Months part or 0 to skip</param>
        /// <param name="days">Days part or 0 to skip</param>
        /// <param name="hours">Hours part or 0 to skip</param>
        /// <param name="minutes">Minutes part or 0 to skip</param>
        /// <param name="seconds">Seconds part or 0 to skip</param>
        /// <param name="negative">Flag whether the duration is negative</param>
        public static Token Duration(int years, int months, int days, int hours, int minutes, int seconds, bool negative = false) => Duration(DurationStr(years, months, days, hours, minutes, seconds, negative));

        /// <summary>
        /// Creates an expression <see cref="Token"/> from string representing "raw expression"
        /// </summary>
        /// <param name="s">String representing "raw expression"</param>
        public static Token Expr(string s) => new Token(s, true);


        /// <summary>
        /// Creates a date time string in <code>YYYY-MM-DD</code> format
        /// </summary>
        /// <param name="year">Years part</param>
        /// <param name="month">Months part</param>
        /// <param name="day">Days part</param>
        private static string DateStr(int year, int month, int day)
        {
            var d = $"{year:0000}-{month:00}-{day:00}";
            return d;
        }

        /// <summary>
        /// Creates a time string in <code>HHmmSS</code> format
        /// or <code>HHmm</code> format if <paramref name="second"/> is 0
        /// </summary>
        /// <param name="hour">Hours part</param>
        /// <param name="minute">Minutes part</param>
        /// <param name="second">Seconds part or 0 to skip</param>
        private static string TimeStr(int hour, int minute, int second)
        {
            var t = $"{hour:00}:{minute:00}";
            if (second > 0) t += $":{second:00}";
            return t;
        }

        /// <summary>
        /// Creates a date time string in <code>YYYY-MM-DDTHHmmSS</code> format
        /// or <code>YYYY-MM-DDTHHmm</code> format if <paramref name="second"/> is 0
        /// or <code>YYYY-MM-DD</code> format if all time parts are 0
        /// </summary>
        /// <param name="year">Years part</param>
        /// <param name="month">Months part</param>
        /// <param name="day">Days part</param>
        /// <param name="hour">Hours part</param>
        /// <param name="minute">Minutes part</param>
        /// <param name="second">Seconds part or 0 to skip</param>
        private static string DateTimeStr(int year, int month, int day, int hour, int minute, int second)
        {
            var d = DateStr(year, month, day);
            var t = (hour > 0 | minute > 0 | second > 0) ? $"T{TimeStr(hour, minute, second)}" : "";
            return $"{d}{t}";
        }

        /// <summary>
        /// Creates a string representing the duration in XML (ISO 8601) format (see https://www.w3.org/TR/xmlschema-2/#duration)
        /// </summary>
        /// <param name="years">Years part or 0 to skip</param>
        /// <param name="months">Months part or 0 to skip</param>
        /// <param name="days">Days part or 0 to skip</param>
        /// <param name="hours">Hours part or 0 to skip</param>
        /// <param name="minutes">Minutes part or 0 to skip</param>
        /// <param name="seconds">Seconds part or 0 to skip</param>
        /// <param name="negative">Flag whether the duration is negative</param>
        private static string DurationStr(int years, int months, int days, int hours, int minutes, int seconds, bool negative = false)
        {
            var prefix = $"{(negative ? "-" : "")}P";
            var d = "";
            d += years > 0 ? $"{years}Y" : "";
            d += months > 0 ? $"{months}M" : "";
            d += days > 0 ? $"{days}D" : "";
            var t = "";
            t += hours > 0 ? $"{hours}H" : "";
            t += minutes > 0 ? $"{minutes}M" : "";
            t += seconds > 0 ? $"{seconds}S" : "";
            t = t != "" ? $"T{t}" : t;
            return $"{prefix}{d}{t}";
        }
    }
}
