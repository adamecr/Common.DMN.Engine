using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.test.dummy

{
    [TestClass]
    [TestCategory("DummyPlayground")]
    public class DummyPlaygroundToRemove
    {
        [TestMethod]
        public void Dummy1()
        {
            var nl = Environment.NewLine;
            var split = "//------------------------------------" + nl;

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            dir = Path.Combine(dir, "dmn");
            var o = "";
            var p = "";
            var d = "";
            var idx = 0;



            foreach (var file in Directory.GetFiles(dir, "*.dmn"))
            {
                var fileName = Path.GetFileName(file);
                if (
                    fileName.ToLower().EndsWith("_err.dmn") ||
                    fileName == "hitpolicy_WrongAggregation.dmn" ||
                    fileName == "hitpolicy_WrongPolicy.dmn") continue;

                
                var model = DmnParser.Parse(file);
                var def = DmnDefinitionFactory.CreateDmnDefinition(model);
                idx++;
                var prefix = $"f{idx:0#}";
                var dmnPropName = fileName.Replace(".dmn", "");
                dmnPropName = char.ToUpperInvariant(dmnPropName[0]) + dmnPropName.Substring(1);
                d += $@"  Files[""{fileName}""]={dmnPropName};"+nl;

                p += $" public static DmnDefinition {dmnPropName} {{get;}}" + nl;

                o += split;
                o += $"//{fileName}" + nl;
                o += split;
                o += nl;

                o += $"{dmnPropName} = new DmnDefinitionBuilder()" + nl;

                foreach (var  variable in def.Variables.Values)
                {
                    if (variable.IsInputParameter)
                    {
                        if (variable.Type != null)
                        {
                            o += $@"  .WithInput<{variable.Type?.Name ?? "object"}>(""{variable.Name}"", out var {prefix}{variable.Name})" + nl;
                        }
                        else
                        {
                            o+=$@"  .WithInput(""{variable.Name}"", out var {prefix}{variable.Name})" + nl;
                        }
                    }
                    else
                    {
                        o += $@"  .WithVariable<{variable.Type?.Name ?? "object"}>(""{variable.Name}"", out var {prefix}{variable.Name})" + nl;
                    }
                }

                var generatedDecisions = new List<IDmnDecision>();
                foreach (var decision in def.Decisions.Values)
                {
                    o = GenerateDecisionBuilder(prefix, decision, o, generatedDecisions);
                }

                o += "  .Build();" + nl;
                o += nl;


            }

            var c = "";
            c += "public static class DmnBuilderSamples{" + nl;
            c += " public static Dictionary<string,DmnDefinition> Files=new Dictionary<string,DmnDefinition>();" + nl;
            c += p + nl;
            c += " static DmnBuilderSamples(){" + nl;
            c += o + nl;
            c += nl;
            c += d;
            c += " }" + nl;
            c += "}" + nl;




        }
     
        private static string GenerateDecisionBuilder(string prefix, IDmnDecision decision, string o, List<IDmnDecision> generatedDecisions)
        {
            if (generatedDecisions.Contains(decision)) return o;
            foreach (var requiredDecision in decision.RequiredDecisions)
            {
                o = GenerateDecisionBuilder(prefix, requiredDecision, o, generatedDecisions);
            }

            var nl = Environment.NewLine;
            var outDecision = $"{prefix}{decision.Name.NormalizeName()}";

            if (decision is DmnExpressionDecision expressionDecision)
            {
                o += nl;
                o += $@"  .WithExpressionDecision(""{decision.Name.CodeEncodeStr()}"", eDecision =>" + nl;
                o +=
                    $@"       eDecision.Put(""{expressionDecision.Expression.CodeEncodeStr()}"").To({prefix}{expressionDecision.Output.Name})" +
                    nl;
                if (decision.RequiredInputs != null)
                {
                    o = decision.RequiredInputs.Aggregate(o,
                        (current, requiredInput) => current + $@"       .Requires({prefix}{requiredInput.Name})" + nl);
                }

                if (decision.RequiredDecisions != null)
                {
                    o = decision.RequiredDecisions.Aggregate(o,
                        (current, requiredDec) =>
                            current + $@"       .Requires({prefix}{requiredDec.Name.NormalizeName()})" + nl);
                }

                o += $@"     ,out var {outDecision})" + nl;
            }

            if (decision is DmnDecisionTable table)
            {
                o += nl;
                o += $@"  .WithTableDecision(""{decision.Name}"", table =>" + nl;
                o += $@"     table" + nl;
                foreach (var tableInput in table.Inputs)
                {
                    if (tableInput.Variable != null)
                    {
                        o += $@"        .WithInput({prefix}{tableInput.Variable.Name}, out var {prefix}Input{tableInput.Index}";
                    }
                    else
                    {
                        o +=
                            $@"        .WithInput(""{tableInput.Expression.CodeEncodeStr()}"", out var {prefix}Input{tableInput.Index}";
                    }

                    if (tableInput.AllowedValues != null && tableInput.AllowedValues.Length > 0)
                    {
                        o += "," + string.Join(", ", tableInput.AllowedValues.Select(a => $@"""{a}"""));
                    }

                    o += ")" + nl;
                }

                foreach (var tableOutput in table.Outputs.OrderBy(i => i.Index))
                {
                    o += $@"        .WithOutput({prefix}{tableOutput.Variable.Name}, out var {prefix}Output{tableOutput.Index}";

                    if (tableOutput.AllowedValues != null && tableOutput.AllowedValues.Length > 0)
                    {
                        o += "," + string.Join(", ", tableOutput.AllowedValues.Select(a => $@"""{a}"""));
                    }

                    o += ")" + nl;
                }

                o += $@"        .WithHitPolicy(HitPolicyEnum.{table.HitPolicy})" + nl;
                o += $@"        .WithAggregation(CollectHitPolicyAggregationEnum.{table.Aggregation})" + nl;

                foreach (var rule in table.Rules.OrderBy(r => r.Index))
                {
                    o += $@"        .WithRule(""{rule.Name}"",{(!string.IsNullOrEmpty(rule.Description) ? $@"""{rule.Description.CodeEncodeStr()}"", " : "")} r=>r" + nl;
                    var firstInput = true;
                    var firstOutput = true;
                    foreach (var ruleInput in rule.Inputs)
                    {//TODO How to get unparsed (original) expressions?
                        o +=
                            $@"          .{(firstInput ? "When" : "And")}({prefix}Input{ruleInput.Input.Index},""{ruleInput.UnparsedExpression.CodeEncodeStr()}"")" +
                            nl;
                        firstInput = false;
                    }

                    if (firstInput)
                    {
                        //no input
                        o += $@"          .Always()" + nl;
                    }

                    foreach (var ruleOutput in rule.Outputs)
                    {
                        o +=
                            $@"          .{(firstOutput ? "Then" : "And")}({prefix}Output{ruleOutput.Output.Index},""{ruleOutput.Expression.CodeEncodeStr()}"")" +
                            nl;
                        firstOutput = false;
                    }

                    o += $@"          )" + nl;
                }

                if (decision.RequiredInputs != null)
                {
                    o = decision.RequiredInputs.Aggregate(o,
                        (current, requiredInput) => current + $@"       .Requires({prefix}{requiredInput.Name})" + nl);
                }

                if (decision.RequiredDecisions != null)
                {
                    o = decision.RequiredDecisions.Aggregate(o,
                        (current, requiredDec) =>
                            current + $@"       .Requires({prefix}{requiredDec.Name.NormalizeName()})" + nl);
                }

                o += $@"     ,out var {outDecision})" + nl;
            }

            generatedDecisions.Add(decision);
            return o;
        }

       

    }

    public static class StringExtensions
    {
        public static string NormalizeName(this string name)
        {
            return name.Where(c => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9').Aggregate("", (current, c) => current + c);
        }
        
       
        public static string CodeEncodeStr(this string expr)
        {
            return expr?.Replace(@"""", @"\""");
        }
    }


}
