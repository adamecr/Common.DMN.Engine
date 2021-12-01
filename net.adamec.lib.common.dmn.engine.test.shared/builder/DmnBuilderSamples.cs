using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    public static class DmnBuilderSamples
    {
        public static Dictionary<string, DmnDefinition> Files = new Dictionary<string, DmnDefinition>();

        public static DmnDefinition AllowedValues { get; }
        public static DmnDefinition Datatypes { get; }
        public static DmnDefinition Dynamictypes { get; }
        public static DmnDefinition Hitpolicy_Any { get; }
        public static DmnDefinition Hitpolicy_Collect_Count { get; }
        public static DmnDefinition Hitpolicy_Collect_CountBool { get; }
        public static DmnDefinition Hitpolicy_Collect_CountStr { get; }
        public static DmnDefinition Hitpolicy_Collect_List { get; }
        public static DmnDefinition Hitpolicy_Collect_Max { get; }
        public static DmnDefinition Hitpolicy_Collect_MaxBool { get; }
        public static DmnDefinition Hitpolicy_Collect_Min { get; }
        public static DmnDefinition Hitpolicy_Collect_MinBool { get; }
        public static DmnDefinition Hitpolicy_Collect_Sum { get; }
        public static DmnDefinition Hitpolicy_Collect_SumBool { get; }
        public static DmnDefinition Hitpolicy_Collect_SumStr { get; }
        public static DmnDefinition Hitpolicy_First { get; }
        public static DmnDefinition Hitpolicy_MultiOut_Any { get; }
        public static DmnDefinition Hitpolicy_MultiOut_First { get; }
        public static DmnDefinition Hitpolicy_MultiOut_OutputOrder { get; }
        public static DmnDefinition Hitpolicy_MultiOut_Priority { get; }
        public static DmnDefinition Hitpolicy_MultiOut_RuleOrder { get; }
        public static DmnDefinition Hitpolicy_MultiOut_Unique { get; }
        public static DmnDefinition Hitpolicy_OutputOrder { get; }
        public static DmnDefinition Hitpolicy_OutputOrder_NoOutWithAllowed { get; }
        public static DmnDefinition Hitpolicy_Priority { get; }
        public static DmnDefinition Hitpolicy_Priority_NoOutWithAllowed { get; }
        public static DmnDefinition Hitpolicy_RuleOrder { get; }
        public static DmnDefinition Hitpolicy_Unique { get; }
        public static DmnDefinition Parallel { get; }
        public static DmnDefinition Sfeel { get; }
        public static DmnDefinition Test { get; }

        static DmnBuilderSamples()
        {
            //------------------------------------
            //allowedValues.dmn
            //------------------------------------

            AllowedValues = new DmnDefinitionBuilder()
              .WithInput<String>("a", out var f01a)
              .WithInput("b", out var f01b)
              .WithVariable<String>("c", out var f01c)

              .WithTableDecision("Test", table =>
                 table
                    .WithInput(f01a, out var f01Input0, "one", "two", "three")
                    .WithInput("b", out var f01Input1, "dog", "cat", "horse")
                    .WithOutput(f01c, out var f01Output0, "blue", "white", "red")
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-24", r => r
                      .When(f01Input0, "\"one\"")
                      .And(f01Input1, "\"dog\"")
                      .Then(f01Output0, "\"blue\"")
                      )
                    .WithRule("row-816543858-25", r => r
                      .When(f01Input0, "\"one\", \"two\"")
                      .And(f01Input1, "\"cat\"")
                      .Then(f01Output0, "\"white\"")
                      )
                    .WithRule("row-816543858-26", r => r
                      .When(f01Input0, "\"three\"")
                      .Then(f01Output0, "\"red\"")
                      )
                    .WithRule("row-816543858-27", r => r
                      .When(f01Input0, "\"one\"")
                      .And(f01Input1, "\"whale\"")
                      .Then(f01Output0, "\"blue\"")
                      )
                    .WithRule("row-816543858-28", r => r
                      .When(f01Input0, "\"four\"")
                      .And(f01Input1, "\"cat\"")
                      .Then(f01Output0, "\"red\"")
                      )
                    .WithRule("row-816543858-29", r => r
                      .When(f01Input0, "\"one\"")
                      .And(f01Input1, "\"horse\"")
                      .Then(f01Output0, "\"yellow\"")
                      )
                   .Requires(f01a)
                   .Requires(f01b)
                 , out var f01Test)
              .Build();

            //------------------------------------
            //datatypes.dmn
            //------------------------------------

            Datatypes = new DmnDefinitionBuilder()
              .WithInput<String>("string", out var f02string)
              .WithInput<Boolean>("bool", out var f02bool)
              .WithInput<Int32>("int", out var f02int)
              .WithInput<Int64>("long", out var f02long)
              .WithInput<Double>("double", out var f02double)
              .WithInput<DateTime>("date", out var f02date)
              .WithVariable<String>("out", out var f02out)

              .WithTableDecision("Test", table =>
                 table
                    .WithInput(f02bool, out var f02Input0)
                    .WithInput(f02int, out var f02Input1)
                    .WithInput(f02string, out var f02Input2)
                    .WithInput(f02long, out var f02Input3)
                    .WithInput(f02double, out var f02Input4)
                    .WithInput(f02date, out var f02Input5)
                    .WithOutput(f02out, out var f02Output0)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-19", r => r
                      .When(f02Input0, "true")
                      .And(f02Input5, "< date and time(\"2018-03-16T00:00:00\")")
                      .Then(f02Output0, "\"fallback\"")
                      )
                   .Requires(f02string)
                   .Requires(f02bool)
                   .Requires(f02int)
                   .Requires(f02long)
                   .Requires(f02double)
                   .Requires(f02date)
                 , out var f02Test)
              .Build();

            //------------------------------------
            //dynamictypes.dmn
            //------------------------------------

            Dynamictypes = new DmnDefinitionBuilder()
              .WithInput("dyna", out var f03dyna)
              .WithVariable<String>("a", out var f03a)
              .WithVariable<Boolean>("b", out var f03b)
              .WithVariable<String>("output_1", out var f03output_1)

              .WithExpressionDecision("Name to \"a\"", eDecision =>
                   eDecision.Put("dyna.Name").To(f03a)
                   .Requires(f03dyna)
                 , out var f03Nametoa)

              .WithExpressionDecision("IsOk to \"b\"", eDecision =>
                   eDecision.Put("dyna.IsOk").To(f03b)
                   .Requires(f03dyna)
                 , out var f03IsOktob)

              .WithTableDecision("Test", table =>
                 table
                    .WithInput(f03a, out var f03Input0)
                    .WithInput(f03b, out var f03Input1)
                    .WithInput("dyna.Direct", out var f03Input2)
                    .WithOutput(f03output_1, out var f03Output0)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-20", r => r
                      .When(f03Input2, "not(\"over\")")
                      .Then(f03Output0, "a+(b!=null?b.ToString():\"\")+dyna.Direct")
                      )
                    .WithRule("row-816543858-21", r => r
                      .When(f03Input2, "\"over\"")
                      .Then(f03Output0, "\"dyna.Direct==over\"")
                      )
                   .Requires(f03dyna)
                   .Requires(f03Nametoa)
                   .Requires(f03IsOktob)
                 , out var f03Test)
              .Build();

            //------------------------------------
            //hitpolicy_Any.dmn
            //------------------------------------

            Hitpolicy_Any = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f04a)
              .WithInput<Int32>("b", out var f04b)
              .WithVariable<String>("o", out var f04o)

              .WithTableDecision("Any", table =>
                 table
                    .WithInput(f04a, out var f04Input0)
                    .WithInput(f04b, out var f04Input1)
                    .WithOutput(f04o, out var f04Output0)
                    .WithHitPolicy(HitPolicyEnum.Any)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-23", "any for 5 - 2", r => r
                      .When(f04Input0, "<= 5")
                      .And(f04Input1, "2")
                      .Then(f04Output0, "\"x5 2\"")
                      )
                    .WithRule("row-816543858-33", r => r
                      .When(f04Input0, "5")
                      .And(f04Input1, "1")
                      .Then(f04Output0, "\"5 1\"")
                      )
                    .WithRule("row-816543858-43", "any uniqe for 5 - 2", r => r
                      .When(f04Input0, "5")
                      .And(f04Input1, "2")
                      .Then(f04Output0, "\"x5 2\"")
                      )
                    .WithRule("row-816543858-53", "err not same for 6-3", r => r
                      .When(f04Input0, "6")
                      .Then(f04Output0, "\"6\"")
                      )
                    .WithRule("row-816543858-63", r => r
                      .When(f04Input0, "> 6")
                      .And(f04Input1, "2")
                      .Then(f04Output0, "\">6 2\"")
                      )
                    .WithRule("row-816543858-73", "empty out", r => r
                      .When(f04Input0, "> 6")
                      .And(f04Input1, "1")
                      .Then(f04Output0, "")
                      )
                    .WithRule("row-816543858-133", "err not same for 6-3", r => r
                      .When(f04Input1, "3")
                      .Then(f04Output0, "\"- 3\"")
                      )
                   .Requires(f04a)
                   .Requires(f04b)
                 , out var f04Any)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_Count.dmn
            //------------------------------------

            Hitpolicy_Collect_Count = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f05a)
              .WithInput<Int32>("b", out var f05b)
              .WithVariable<Int64>("o", out var f05o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f05a, out var f05Input0)
                    .WithInput(f05b, out var f05Input1)
                    .WithOutput(f05o, out var f05Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Count)
                    .WithRule("row-816543858-1", r => r
                      .When(f05Input0, "< 5")
                      .And(f05Input1, "1")
                      .Then(f05Output0, "5")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f05Input0, "<= 5")
                      .And(f05Input1, "2")
                      .Then(f05Output0, "3")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f05Input0, "5")
                      .And(f05Input1, "1")
                      .Then(f05Output0, "4")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f05Input0, "5")
                      .Then(f05Output0, "8")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f05Input0, "6")
                      .Then(f05Output0, "2")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f05Input0, ">= 6")
                      .And(f05Input1, "2")
                      .Then(f05Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f05Input0, ">= 6")
                      .And(f05Input1, "1")
                      .Then(f05Output0, "1")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f05Input1, "3")
                      .Then(f05Output0, "2")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f05Input0, "9")
                      .And(f05Input1, "1")
                      .Then(f05Output0, "3")
                      )
                   .Requires(f05a)
                   .Requires(f05b)
                 , out var f05Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_CountBool.dmn
            //------------------------------------

            Hitpolicy_Collect_CountBool = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f06a)
              .WithInput<Int32>("b", out var f06b)
              .WithVariable<Boolean>("o", out var f06o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f06a, out var f06Input0)
                    .WithInput(f06b, out var f06Input1)
                    .WithOutput(f06o, out var f06Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Count)
                    .WithRule("row-816543858-1", r => r
                      .When(f06Input0, "< 5")
                      .And(f06Input1, "1")
                      .Then(f06Output0, "true")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f06Input0, "<= 5")
                      .And(f06Input1, "2")
                      .Then(f06Output0, "true")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f06Input0, "5")
                      .And(f06Input1, "1")
                      .Then(f06Output0, "false")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f06Input0, "5")
                      .Then(f06Output0, "true")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f06Input0, "6")
                      .Then(f06Output0, "true")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f06Input0, ">= 6")
                      .And(f06Input1, "2")
                      .Then(f06Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f06Input0, ">= 6")
                      .And(f06Input1, "1")
                      .Then(f06Output0, "false")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f06Input1, "3")
                      .Then(f06Output0, "true")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f06Input0, "9")
                      .And(f06Input1, "1")
                      .Then(f06Output0, "true")
                      )
                   .Requires(f06a)
                   .Requires(f06b)
                 , out var f06Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_CountStr.dmn
            //------------------------------------

            Hitpolicy_Collect_CountStr = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f07a)
              .WithInput<Int32>("b", out var f07b)
              .WithVariable<String>("o", out var f07o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f07a, out var f07Input0)
                    .WithInput(f07b, out var f07Input1)
                    .WithOutput(f07o, out var f07Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Count)
                    .WithRule("row-816543858-1", r => r
                      .When(f07Input0, "< 5")
                      .And(f07Input1, "1")
                      .Then(f07Output0, "\"s\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f07Input0, "<= 5")
                      .And(f07Input1, "2")
                      .Then(f07Output0, "\"h\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f07Input0, "5")
                      .And(f07Input1, "1")
                      .Then(f07Output0, "\"h\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f07Input0, "5")
                      .Then(f07Output0, "")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f07Input0, "6")
                      .Then(f07Output0, "\"h\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f07Input0, ">= 6")
                      .And(f07Input1, "2")
                      .Then(f07Output0, "\"r\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f07Input0, ">= 6")
                      .And(f07Input1, "1")
                      .Then(f07Output0, "\"k\"")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f07Input1, "3")
                      .Then(f07Output0, "")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f07Input0, "9")
                      .And(f07Input1, "1")
                      .Then(f07Output0, "\"t\"")
                      )
                   .Requires(f07a)
                   .Requires(f07b)
                 , out var f07Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_List.dmn
            //------------------------------------

            Hitpolicy_Collect_List = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f08a)
              .WithInput<Int32>("b", out var f08b)
              .WithVariable<Int64>("o", out var f08o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f08a, out var f08Input0)
                    .WithInput(f08b, out var f08Input1)
                    .WithOutput(f08o, out var f08Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f08Input0, "< 5")
                      .And(f08Input1, "1")
                      .Then(f08Output0, "5")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f08Input0, "<= 5")
                      .And(f08Input1, "2")
                      .Then(f08Output0, "3")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f08Input0, "5")
                      .And(f08Input1, "1")
                      .Then(f08Output0, "4")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f08Input0, "5")
                      .Then(f08Output0, "8")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f08Input0, "6")
                      .Then(f08Output0, "2")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f08Input0, ">= 6")
                      .And(f08Input1, "2")
                      .Then(f08Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f08Input0, ">= 6")
                      .And(f08Input1, "1")
                      .Then(f08Output0, "1")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f08Input1, "3")
                      .Then(f08Output0, "2")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f08Input0, "9")
                      .And(f08Input1, "1")
                      .Then(f08Output0, "3")
                      )
                   .Requires(f08a)
                   .Requires(f08b)
                 , out var f08Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_Max.dmn
            //------------------------------------

            Hitpolicy_Collect_Max = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f09a)
              .WithInput<Int32>("b", out var f09b)
              .WithVariable<Int64>("o", out var f09o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f09a, out var f09Input0)
                    .WithInput(f09b, out var f09Input1)
                    .WithOutput(f09o, out var f09Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Max)
                    .WithRule("row-816543858-1", r => r
                      .When(f09Input0, "< 5")
                      .And(f09Input1, "1")
                      .Then(f09Output0, "5")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f09Input0, "<= 5")
                      .And(f09Input1, "2")
                      .Then(f09Output0, "3")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f09Input0, "5")
                      .And(f09Input1, "1")
                      .Then(f09Output0, "4")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f09Input0, "5")
                      .Then(f09Output0, "8")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f09Input0, "6")
                      .Then(f09Output0, "2")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f09Input0, ">= 6")
                      .And(f09Input1, "2")
                      .Then(f09Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f09Input0, ">= 6")
                      .And(f09Input1, "1")
                      .Then(f09Output0, "1")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f09Input1, "3")
                      .Then(f09Output0, "2")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f09Input0, "9")
                      .And(f09Input1, "1")
                      .Then(f09Output0, "3")
                      )
                   .Requires(f09a)
                   .Requires(f09b)
                 , out var f09Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_MaxBool.dmn
            //------------------------------------

            Hitpolicy_Collect_MaxBool = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f10a)
              .WithInput<Int32>("b", out var f10b)
              .WithVariable<Boolean>("o", out var f10o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f10a, out var f10Input0)
                    .WithInput(f10b, out var f10Input1)
                    .WithOutput(f10o, out var f10Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Max)
                    .WithRule("row-816543858-1", r => r
                      .When(f10Input0, "< 5")
                      .And(f10Input1, "1")
                      .Then(f10Output0, "true")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f10Input0, "<= 5")
                      .And(f10Input1, "2")
                      .Then(f10Output0, "true")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f10Input0, "5")
                      .And(f10Input1, "1")
                      .Then(f10Output0, "false")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f10Input0, "5")
                      .Then(f10Output0, "true")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f10Input0, "6")
                      .Then(f10Output0, "true")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f10Input0, ">= 6")
                      .And(f10Input1, "2")
                      .Then(f10Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f10Input0, ">= 6")
                      .And(f10Input1, "1")
                      .Then(f10Output0, "false")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f10Input1, "3")
                      .Then(f10Output0, "true")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f10Input0, "9")
                      .And(f10Input1, "1")
                      .Then(f10Output0, "true")
                      )
                   .Requires(f10a)
                   .Requires(f10b)
                 , out var f10Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_Min.dmn
            //------------------------------------

            Hitpolicy_Collect_Min = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f11a)
              .WithInput<Int32>("b", out var f11b)
              .WithVariable<Int64>("o", out var f11o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f11a, out var f11Input0)
                    .WithInput(f11b, out var f11Input1)
                    .WithOutput(f11o, out var f11Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Min)
                    .WithRule("row-816543858-1", r => r
                      .When(f11Input0, "< 5")
                      .And(f11Input1, "1")
                      .Then(f11Output0, "5")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f11Input0, "<= 5")
                      .And(f11Input1, "2")
                      .Then(f11Output0, "3")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f11Input0, "5")
                      .And(f11Input1, "1")
                      .Then(f11Output0, "4")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f11Input0, "5")
                      .Then(f11Output0, "8")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f11Input0, "6")
                      .Then(f11Output0, "2")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f11Input0, ">= 6")
                      .And(f11Input1, "2")
                      .Then(f11Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f11Input0, ">= 6")
                      .And(f11Input1, "1")
                      .Then(f11Output0, "1")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f11Input1, "3")
                      .Then(f11Output0, "2")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f11Input0, "9")
                      .And(f11Input1, "1")
                      .Then(f11Output0, "3")
                      )
                   .Requires(f11a)
                   .Requires(f11b)
                 , out var f11Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_MinBool.dmn
            //------------------------------------

            Hitpolicy_Collect_MinBool = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f12a)
              .WithInput<Int32>("b", out var f12b)
              .WithVariable<Boolean>("o", out var f12o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f12a, out var f12Input0)
                    .WithInput(f12b, out var f12Input1)
                    .WithOutput(f12o, out var f12Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Min)
                    .WithRule("row-816543858-1", r => r
                      .When(f12Input0, "< 5")
                      .And(f12Input1, "1")
                      .Then(f12Output0, "true")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f12Input0, "<= 5")
                      .And(f12Input1, "2")
                      .Then(f12Output0, "true")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f12Input0, "5")
                      .And(f12Input1, "1")
                      .Then(f12Output0, "false")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f12Input0, "5")
                      .Then(f12Output0, "true")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f12Input0, "6")
                      .Then(f12Output0, "true")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f12Input0, ">= 6")
                      .And(f12Input1, "2")
                      .Then(f12Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f12Input0, ">= 6")
                      .And(f12Input1, "1")
                      .Then(f12Output0, "false")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f12Input1, "3")
                      .Then(f12Output0, "true")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f12Input0, "9")
                      .And(f12Input1, "1")
                      .Then(f12Output0, "true")
                      )
                   .Requires(f12a)
                   .Requires(f12b)
                 , out var f12Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_Sum.dmn
            //------------------------------------

            Hitpolicy_Collect_Sum = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f13a)
              .WithInput<Int32>("b", out var f13b)
              .WithVariable<Int64>("o", out var f13o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f13a, out var f13Input0)
                    .WithInput(f13b, out var f13Input1)
                    .WithOutput(f13o, out var f13Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Sum)
                    .WithRule("row-816543858-1", r => r
                      .When(f13Input0, "< 5")
                      .And(f13Input1, "1")
                      .Then(f13Output0, "5")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f13Input0, "<= 5")
                      .And(f13Input1, "2")
                      .Then(f13Output0, "3")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f13Input0, "5")
                      .And(f13Input1, "1")
                      .Then(f13Output0, "4")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f13Input0, "5")
                      .Then(f13Output0, "8")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f13Input0, "6")
                      .Then(f13Output0, "2")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f13Input0, ">= 6")
                      .And(f13Input1, "2")
                      .Then(f13Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f13Input0, ">= 6")
                      .And(f13Input1, "1")
                      .Then(f13Output0, "1")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f13Input1, "3")
                      .Then(f13Output0, "2")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f13Input0, "9")
                      .And(f13Input1, "1")
                      .Then(f13Output0, "3")
                      )
                   .Requires(f13a)
                   .Requires(f13b)
                 , out var f13Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_SumBool.dmn
            //------------------------------------

            Hitpolicy_Collect_SumBool = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f14a)
              .WithInput<Int32>("b", out var f14b)
              .WithVariable<Boolean>("o", out var f14o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f14a, out var f14Input0)
                    .WithInput(f14b, out var f14Input1)
                    .WithOutput(f14o, out var f14Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Sum)
                    .WithRule("row-816543858-1", r => r
                      .When(f14Input0, "< 5")
                      .And(f14Input1, "1")
                      .Then(f14Output0, "true")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f14Input0, "<= 5")
                      .And(f14Input1, "2")
                      .Then(f14Output0, "true")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f14Input0, "5")
                      .And(f14Input1, "1")
                      .Then(f14Output0, "false")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f14Input0, "5")
                      .Then(f14Output0, "true")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f14Input0, "6")
                      .Then(f14Output0, "true")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f14Input0, ">= 6")
                      .And(f14Input1, "2")
                      .Then(f14Output0, "")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f14Input0, ">= 6")
                      .And(f14Input1, "1")
                      .Then(f14Output0, "false")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f14Input1, "3")
                      .Then(f14Output0, "true")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f14Input0, "9")
                      .And(f14Input1, "1")
                      .Then(f14Output0, "true")
                      )
                   .Requires(f14a)
                   .Requires(f14b)
                 , out var f14Collect)
              .Build();

            //------------------------------------
            //hitpolicy_Collect_SumStr.dmn
            //------------------------------------

            Hitpolicy_Collect_SumStr = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f15a)
              .WithInput<Int32>("b", out var f15b)
              .WithVariable<String>("o", out var f15o)

              .WithTableDecision("Collect", table =>
                 table
                    .WithInput(f15a, out var f15Input0)
                    .WithInput(f15b, out var f15Input1)
                    .WithOutput(f15o, out var f15Output0)
                    .WithHitPolicy(HitPolicyEnum.Collect)
                    .WithAggregation(CollectHitPolicyAggregationEnum.Sum)
                    .WithRule("row-816543858-1", r => r
                      .When(f15Input0, "< 5")
                      .And(f15Input1, "1")
                      .Then(f15Output0, "\"s\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f15Input0, "<= 5")
                      .And(f15Input1, "2")
                      .Then(f15Output0, "\"h\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f15Input0, "5")
                      .And(f15Input1, "1")
                      .Then(f15Output0, "\"h\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f15Input0, "5")
                      .Then(f15Output0, "")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f15Input0, "6")
                      .Then(f15Output0, "\"h\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f15Input0, ">= 6")
                      .And(f15Input1, "2")
                      .Then(f15Output0, "\"r\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f15Input0, ">= 6")
                      .And(f15Input1, "1")
                      .Then(f15Output0, "\"k\"")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f15Input1, "3")
                      .Then(f15Output0, "")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f15Input0, "9")
                      .And(f15Input1, "1")
                      .Then(f15Output0, "\"t\"")
                      )
                   .Requires(f15a)
                   .Requires(f15b)
                 , out var f15Collect)
              .Build();

            //------------------------------------
            //hitpolicy_First.dmn
            //------------------------------------

            Hitpolicy_First = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f16a)
              .WithInput<Int32>("b", out var f16b)
              .WithVariable<String>("o", out var f16o)

              .WithTableDecision("First", table =>
                 table
                    .WithInput(f16a, out var f16Input0)
                    .WithInput(f16b, out var f16Input1)
                    .WithOutput(f16o, out var f16Output0)
                    .WithHitPolicy(HitPolicyEnum.First)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-12", r => r
                      .When(f16Input0, "< 5")
                      .And(f16Input1, "1")
                      .Then(f16Output0, "\"<5 1\"")
                      )
                    .WithRule("row-816543858-22", "first 5", r => r
                      .When(f16Input0, "<= 5")
                      .And(f16Input1, "2")
                      .Then(f16Output0, "\"<=5 2\"")
                      )
                    .WithRule("row-816543858-32", r => r
                      .When(f16Input0, "5")
                      .And(f16Input1, "1")
                      .Then(f16Output0, "\"5 1\"")
                      )
                    .WithRule("row-816543858-42", r => r
                      .When(f16Input0, "5")
                      .And(f16Input1, "2")
                      .Then(f16Output0, "\"5 2\"")
                      )
                    .WithRule("row-816543858-52", r => r
                      .When(f16Input0, "6")
                      .Then(f16Output0, "\"6\"")
                      )
                    .WithRule("row-816543858-62", r => r
                      .When(f16Input1, "2")
                      .Then(f16Output0, "\" - 2\"")
                      )
                    .WithRule("row-816543858-72", "empty out", r => r
                      .When(f16Input1, "1")
                      .Then(f16Output0, "")
                      )
                    .WithRule("row-816543858-11", r => r
                      .Always()
                      .Then(f16Output0, "\"fallback\"")
                      )
                   .Requires(f16a)
                   .Requires(f16b)
                 , out var f16First)
              .Build();

            //------------------------------------
            //hitpolicy_MultiOut_Any.dmn
            //------------------------------------

            Hitpolicy_MultiOut_Any = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f17a)
              .WithInput<Int32>("b", out var f17b)
              .WithVariable<String>("o1", out var f17o1)
              .WithVariable<Int32>("o2", out var f17o2)

              .WithTableDecision("Any", table =>
                 table
                    .WithInput(f17a, out var f17Input0)
                    .WithInput(f17b, out var f17Input1)
                    .WithOutput(f17o1, out var f17Output0)
                    .WithOutput(f17o2, out var f17Output1)
                    .WithHitPolicy(HitPolicyEnum.Any)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f17Input0, "< 5")
                      .And(f17Input1, "1")
                      .Then(f17Output0, "\"b\"")
                      .And(f17Output1, "1")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f17Input0, "4")
                      .And(f17Input1, "1")
                      .Then(f17Output0, "\"b\"")
                      .And(f17Output1, "1")
                      )
                    .WithRule("row-816543858-3", "err", r => r
                      .When(f17Input0, "3")
                      .And(f17Input1, "1")
                      .Then(f17Output0, "\"b\"")
                      .And(f17Output1, "2")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f17Input0, "< 5")
                      .And(f17Input1, "2")
                      .Then(f17Output0, "\"a\"")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f17Input0, "4")
                      .And(f17Input1, "2")
                      .Then(f17Output0, "\"a\"")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-272987607-1", r => r
                      .When(f17Input0, "7")
                      .And(f17Input1, "2")
                      .Then(f17Output0, "\"a\"")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-272987607-2", "err", r => r
                      .When(f17Input0, "3")
                      .And(f17Input1, "2")
                      .Then(f17Output0, "\"b\"")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-272987607-14", "err", r => r
                      .When(f17Input0, "2")
                      .And(f17Input1, "2")
                      .Then(f17Output0, "\"a\"")
                      .And(f17Output1, "1")
                      )
                    .WithRule("row-272987607-15", r => r
                      .When(f17Input1, "2")
                      .Then(f17Output0, "\"a\"")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-272987607-16", r => r
                      .When(f17Input0, "< 5")
                      .And(f17Input1, "3")
                      .Then(f17Output0, "")
                      .And(f17Output1, "3")
                      )
                    .WithRule("row-272987607-17", r => r
                      .When(f17Input0, "4")
                      .And(f17Input1, "3")
                      .Then(f17Output0, "")
                      .And(f17Output1, "3")
                      )
                    .WithRule("row-272987607-18", "err", r => r
                      .When(f17Input0, "3")
                      .And(f17Input1, "3")
                      .Then(f17Output0, "\"c\"")
                      .And(f17Output1, "3")
                      )
                    .WithRule("row-272987607-19", r => r
                      .When(f17Input0, "< 5")
                      .And(f17Input1, "4")
                      .Then(f17Output0, "")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-272987607-20", r => r
                      .When(f17Input0, "4")
                      .And(f17Input1, "4")
                      .Then(f17Output0, "")
                      .And(f17Output1, "")
                      )
                    .WithRule("row-272987607-21", "err", r => r
                      .When(f17Input0, "3")
                      .And(f17Input1, "4")
                      .Then(f17Output0, "")
                      .And(f17Output1, "1")
                      )
                    .WithRule("row-272987607-22", "err", r => r
                      .When(f17Input0, "2")
                      .And(f17Input1, "4")
                      .Then(f17Output0, "\"d\"")
                      .And(f17Output1, "")
                      )
                   .Requires(f17a)
                   .Requires(f17b)
                 , out var f17Any)
              .Build();

            //------------------------------------
            //hitpolicy_MultiOut_First.dmn
            //------------------------------------

            Hitpolicy_MultiOut_First = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f18a)
              .WithInput<Int32>("b", out var f18b)
              .WithVariable<String>("o1", out var f18o1)
              .WithVariable<Int32>("o2", out var f18o2)

              .WithTableDecision("First", table =>
                 table
                    .WithInput(f18a, out var f18Input0)
                    .WithInput(f18b, out var f18Input1)
                    .WithOutput(f18o1, out var f18Output0)
                    .WithOutput(f18o2, out var f18Output1)
                    .WithHitPolicy(HitPolicyEnum.First)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f18Input0, "1")
                      .And(f18Input1, "1")
                      .Then(f18Output0, "\"double one\"")
                      .And(f18Output1, "11")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f18Input1, "2")
                      .Then(f18Output0, "\"b2\"")
                      .And(f18Output1, "a+b")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f18Input0, "1")
                      .And(f18Input1, "3")
                      .Then(f18Output0, "\"13\"")
                      .And(f18Output1, "13")
                      )
                    .WithRule("row-816543858-4", "no o2", r => r
                      .When(f18Input0, "5")
                      .And(f18Input1, "4")
                      .Then(f18Output0, "\"54\"")
                      .And(f18Output1, "")
                      )
                    .WithRule("row-816543858-5", "no o1", r => r
                      .When(f18Input0, "4")
                      .And(f18Input1, "5")
                      .Then(f18Output0, "")
                      .And(f18Output1, "45")
                      )
                    .WithRule("row-272987607-1", "no o1, o2", r => r
                      .When(f18Input0, "5")
                      .And(f18Input1, "5")
                      .Then(f18Output0, "")
                      .And(f18Output1, "")
                      )
                    .WithRule("row-272987607-2", "no hit -/2 is hit first", r => r
                      .When(f18Input0, "5")
                      .And(f18Input1, "2")
                      .Then(f18Output0, "\"52\"")
                      .And(f18Output1, "52")
                      )
                   .Requires(f18a)
                   .Requires(f18b)
                 , out var f18First)
              .Build();

            //------------------------------------
            //hitpolicy_MultiOut_OutputOrder.dmn
            //------------------------------------

            Hitpolicy_MultiOut_OutputOrder = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f19a)
              .WithInput<Int32>("b", out var f19b)
              .WithVariable<String>("o1", out var f19o1)
              .WithVariable<Int32>("o2", out var f19o2)
              .WithVariable<String>("o3", out var f19o3)

              .WithTableDecision("OutputOrder", table =>
                 table
                    .WithInput(f19a, out var f19Input0)
                    .WithInput(f19b, out var f19Input1)
                    .WithOutput(f19o1, out var f19Output0, "a", "b", "c", "d", "e", "z")
                    .WithOutput(f19o2, out var f19Output1)
                    .WithOutput(f19o3, out var f19Output2, "a", "b", "c", "d", "e", "z")
                    .WithHitPolicy(HitPolicyEnum.OutputOrder)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f19Input0, "< 7")
                      .And(f19Input1, "4")
                      .Then(f19Output0, "\"b\"")
                      .And(f19Output1, "7")
                      .And(f19Output2, "\"b\"")
                      )
                    .WithRule("row-816543858-4", "previous rule first- same order \"b/b\", so the first rule in order hit", r => r
                      .When(f19Input0, "5")
                      .And(f19Input1, "4")
                      .Then(f19Output0, "\"b\"")
                      .And(f19Output1, "5")
                      .And(f19Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-3", r => r
                      .When(f19Input1, "4")
                      .Then(f19Output0, "\"b\"")
                      .And(f19Output1, "")
                      .And(f19Output2, "\"c\"")
                      )
                    .WithRule("row-272987607-4", r => r
                      .When(f19Input0, "4")
                      .And(f19Input1, "4")
                      .Then(f19Output0, "\"b\"")
                      .And(f19Output1, "4")
                      .And(f19Output2, "\"a\"")
                      )
                    .WithRule("row-272987607-5", r => r
                      .When(f19Input0, "9")
                      .And(f19Input1, "4")
                      .Then(f19Output0, "\"b\"")
                      .And(f19Output1, "")
                      .And(f19Output2, "\"d\"")
                      )
                    .WithRule("row-272987607-6", r => r
                      .When(f19Input0, "3")
                      .And(f19Input1, "4")
                      .Then(f19Output0, "\"a\"")
                      .And(f19Output1, "")
                      .And(f19Output2, "\"e\"")
                      )
                    .WithRule("row-272987607-7", r => r
                      .When(f19Input0, "3")
                      .Then(f19Output0, "\"a\"")
                      .And(f19Output1, "5")
                      .And(f19Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-8", r => r
                      .When(f19Input0, "[3..7]")
                      .And(f19Input1, "8")
                      .Then(f19Output0, "")
                      .And(f19Output1, "2")
                      .And(f19Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-9", r => r
                      .When(f19Input0, "4")
                      .And(f19Input1, "8")
                      .Then(f19Output0, "")
                      .And(f19Output1, "9")
                      .And(f19Output2, "\"a\"")
                      )
                    .WithRule("row-272987607-10", r => r
                      .When(f19Input0, "5")
                      .And(f19Input1, "8")
                      .Then(f19Output0, "")
                      .And(f19Output1, "1")
                      .And(f19Output2, "\"c\"")
                      )
                    .WithRule("row-272987607-11", r => r
                      .When(f19Input0, "6")
                      .And(f19Input1, "8")
                      .Then(f19Output0, "\"a\"")
                      .And(f19Output1, "2")
                      .And(f19Output2, "\"d\"")
                      )
                   .Requires(f19a)
                   .Requires(f19b)
                 , out var f19OutputOrder)
              .Build();

            //------------------------------------
            //hitpolicy_MultiOut_Priority.dmn
            //------------------------------------

            Hitpolicy_MultiOut_Priority = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f20a)
              .WithInput<Int32>("b", out var f20b)
              .WithVariable<String>("o1", out var f20o1)
              .WithVariable<Int32>("o2", out var f20o2)
              .WithVariable<String>("o3", out var f20o3)

              .WithTableDecision("Priority", table =>
                 table
                    .WithInput(f20a, out var f20Input0)
                    .WithInput(f20b, out var f20Input1)
                    .WithOutput(f20o1, out var f20Output0, "a", "b", "c", "d", "e", "z")
                    .WithOutput(f20o2, out var f20Output1)
                    .WithOutput(f20o3, out var f20Output2, "a", "b", "c", "d", "e", "z")
                    .WithHitPolicy(HitPolicyEnum.Priority)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f20Input0, "< 7")
                      .And(f20Input1, "4")
                      .Then(f20Output0, "\"b\"")
                      .And(f20Output1, "7")
                      .And(f20Output2, "\"b\"")
                      )
                    .WithRule("row-816543858-4", "previous rule hit - same order \"b/b\", so the first rule in order hit", r => r
                      .When(f20Input0, "5")
                      .And(f20Input1, "4")
                      .Then(f20Output0, "\"b\"")
                      .And(f20Output1, "5")
                      .And(f20Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-3", r => r
                      .When(f20Input1, "4")
                      .Then(f20Output0, "\"b\"")
                      .And(f20Output1, "")
                      .And(f20Output2, "\"c\"")
                      )
                    .WithRule("row-272987607-4", r => r
                      .When(f20Input0, "4")
                      .And(f20Input1, "4")
                      .Then(f20Output0, "\"b\"")
                      .And(f20Output1, "4")
                      .And(f20Output2, "\"a\"")
                      )
                    .WithRule("row-272987607-5", "-/4 has priority", r => r
                      .When(f20Input0, "9")
                      .And(f20Input1, "4")
                      .Then(f20Output0, "\"b\"")
                      .And(f20Output1, "")
                      .And(f20Output2, "\"d\"")
                      )
                    .WithRule("row-272987607-6", r => r
                      .When(f20Input0, "3")
                      .And(f20Input1, "4")
                      .Then(f20Output0, "\"a\"")
                      .And(f20Output1, "")
                      .And(f20Output2, "\"e\"")
                      )
                    .WithRule("row-272987607-7", r => r
                      .When(f20Input0, "3")
                      .Then(f20Output0, "\"a\"")
                      .And(f20Output1, "5")
                      .And(f20Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-8", r => r
                      .When(f20Input0, "[3..7]")
                      .And(f20Input1, "8")
                      .Then(f20Output0, "")
                      .And(f20Output1, "2")
                      .And(f20Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-9", r => r
                      .When(f20Input0, "4")
                      .And(f20Input1, "8")
                      .Then(f20Output0, "")
                      .And(f20Output1, "9")
                      .And(f20Output2, "\"a\"")
                      )
                    .WithRule("row-272987607-10", r => r
                      .When(f20Input0, "5")
                      .And(f20Input1, "8")
                      .Then(f20Output0, "")
                      .And(f20Output1, "1")
                      .And(f20Output2, "\"c\"")
                      )
                    .WithRule("row-272987607-11", r => r
                      .When(f20Input0, "6")
                      .And(f20Input1, "8")
                      .Then(f20Output0, "\"a\"")
                      .And(f20Output1, "2")
                      .And(f20Output2, "\"d\"")
                      )
                   .Requires(f20a)
                   .Requires(f20b)
                 , out var f20Priority)
              .Build();

            //------------------------------------
            //hitpolicy_MultiOut_RuleOrder.dmn
            //------------------------------------

            Hitpolicy_MultiOut_RuleOrder = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f21a)
              .WithInput<Int32>("b", out var f21b)
              .WithVariable<String>("o1", out var f21o1)
              .WithVariable<Int32>("o2", out var f21o2)
              .WithVariable<String>("o3", out var f21o3)

              .WithTableDecision("RuleOrder", table =>
                 table
                    .WithInput(f21a, out var f21Input0)
                    .WithInput(f21b, out var f21Input1)
                    .WithOutput(f21o1, out var f21Output0, "a", "b", "c", "d", "e", "z")
                    .WithOutput(f21o2, out var f21Output1)
                    .WithOutput(f21o3, out var f21Output2, "a", "b", "c", "d", "e", "z")
                    .WithHitPolicy(HitPolicyEnum.RuleOrder)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f21Input0, "< 7")
                      .And(f21Input1, "4")
                      .Then(f21Output0, "\"b\"")
                      .And(f21Output1, "7")
                      .And(f21Output2, "\"b\"")
                      )
                    .WithRule("row-816543858-4", "previous rule first- same order \"b/b\", so the first rule in order hit", r => r
                      .When(f21Input0, "5")
                      .And(f21Input1, "4")
                      .Then(f21Output0, "\"b\"")
                      .And(f21Output1, "5")
                      .And(f21Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-3", r => r
                      .When(f21Input1, "4")
                      .Then(f21Output0, "\"b\"")
                      .And(f21Output1, "")
                      .And(f21Output2, "\"c\"")
                      )
                    .WithRule("row-272987607-4", r => r
                      .When(f21Input0, "4")
                      .And(f21Input1, "4")
                      .Then(f21Output0, "\"b\"")
                      .And(f21Output1, "4")
                      .And(f21Output2, "\"a\"")
                      )
                    .WithRule("row-272987607-5", r => r
                      .When(f21Input0, "9")
                      .And(f21Input1, "4")
                      .Then(f21Output0, "\"b\"")
                      .And(f21Output1, "")
                      .And(f21Output2, "\"d\"")
                      )
                    .WithRule("row-272987607-6", r => r
                      .When(f21Input0, "3")
                      .And(f21Input1, "4")
                      .Then(f21Output0, "\"a\"")
                      .And(f21Output1, "")
                      .And(f21Output2, "\"e\"")
                      )
                    .WithRule("row-272987607-7", r => r
                      .When(f21Input0, "3")
                      .Then(f21Output0, "\"a\"")
                      .And(f21Output1, "5")
                      .And(f21Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-8", r => r
                      .When(f21Input0, "[3..7]")
                      .And(f21Input1, "8")
                      .Then(f21Output0, "")
                      .And(f21Output1, "2")
                      .And(f21Output2, "\"b\"")
                      )
                    .WithRule("row-272987607-9", r => r
                      .When(f21Input0, "4")
                      .And(f21Input1, "8")
                      .Then(f21Output0, "")
                      .And(f21Output1, "9")
                      .And(f21Output2, "\"a\"")
                      )
                    .WithRule("row-272987607-10", r => r
                      .When(f21Input0, "5")
                      .And(f21Input1, "8")
                      .Then(f21Output0, "")
                      .And(f21Output1, "1")
                      .And(f21Output2, "\"c\"")
                      )
                    .WithRule("row-272987607-11", r => r
                      .When(f21Input0, "6")
                      .And(f21Input1, "8")
                      .Then(f21Output0, "\"a\"")
                      .And(f21Output1, "2")
                      .And(f21Output2, "\"d\"")
                      )
                   .Requires(f21a)
                   .Requires(f21b)
                 , out var f21RuleOrder)
              .Build();

            //------------------------------------
            //hitpolicy_MultiOut_Unique.dmn
            //------------------------------------

            Hitpolicy_MultiOut_Unique = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f22a)
              .WithInput<Int32>("b", out var f22b)
              .WithVariable<String>("o1", out var f22o1)
              .WithVariable<Int32>("o2", out var f22o2)

              .WithTableDecision("Unique", table =>
                 table
                    .WithInput(f22a, out var f22Input0)
                    .WithInput(f22b, out var f22Input1)
                    .WithOutput(f22o1, out var f22Output0)
                    .WithOutput(f22o2, out var f22Output1)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f22Input0, "1")
                      .And(f22Input1, "1")
                      .Then(f22Output0, "\"double one\"")
                      .And(f22Output1, "11")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f22Input1, "2")
                      .Then(f22Output0, "\"b2\"")
                      .And(f22Output1, "a+b")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f22Input0, "1")
                      .And(f22Input1, "3")
                      .Then(f22Output0, "\"13\"")
                      .And(f22Output1, "13")
                      )
                    .WithRule("row-816543858-4", "no o2", r => r
                      .When(f22Input0, "5")
                      .And(f22Input1, "4")
                      .Then(f22Output0, "\"54\"")
                      .And(f22Output1, "")
                      )
                    .WithRule("row-816543858-5", "no o1", r => r
                      .When(f22Input0, "4")
                      .And(f22Input1, "5")
                      .Then(f22Output0, "")
                      .And(f22Output1, "45")
                      )
                    .WithRule("row-272987607-1", "no o1, o2", r => r
                      .When(f22Input0, "5")
                      .And(f22Input1, "5")
                      .Then(f22Output0, "")
                      .And(f22Output1, "")
                      )
                   .Requires(f22a)
                   .Requires(f22b)
                 , out var f22Unique)
              .Build();

            //------------------------------------
            //hitpolicy_OutputOrder.dmn
            //------------------------------------

            Hitpolicy_OutputOrder = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f23a)
              .WithInput<Int32>("b", out var f23b)
              .WithVariable<String>("o", out var f23o)

              .WithTableDecision("OutputOrder", table =>
                 table
                    .WithInput(f23a, out var f23Input0)
                    .WithInput(f23b, out var f23Input1)
                    .WithOutput(f23o, out var f23Output0, "b", "a", "c", "d")
                    .WithHitPolicy(HitPolicyEnum.OutputOrder)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f23Input0, "< 5")
                      .And(f23Input1, "1")
                      .Then(f23Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f23Input0, "<= 5")
                      .And(f23Input1, "2")
                      .Then(f23Output0, "\"b\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f23Input0, "5")
                      .And(f23Input1, "1")
                      .Then(f23Output0, "\"c\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f23Input0, "5")
                      .Then(f23Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f23Input0, "6")
                      .Then(f23Output0, "\"d\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f23Input0, ">= 6")
                      .And(f23Input1, "2")
                      .Then(f23Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f23Input0, ">= 6")
                      .And(f23Input1, "1")
                      .Then(f23Output0, "")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f23Input1, "3")
                      .Then(f23Output0, "\"c\"")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f23Input0, "9")
                      .And(f23Input1, "1")
                      .Then(f23Output0, "\"a\"")
                      )
                   .Requires(f23a)
                   .Requires(f23b)
                 , out var f23OutputOrder)
              .Build();

            //------------------------------------
            //hitpolicy_OutputOrder_NoOutWithAllowed.dmn
            //------------------------------------

            Hitpolicy_OutputOrder_NoOutWithAllowed = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f24a)
              .WithInput<Int32>("b", out var f24b)
              .WithVariable<String>("o", out var f24o)

              .WithTableDecision("OutputOrder", table =>
                 table
                    .WithInput(f24a, out var f24Input0)
                    .WithInput(f24b, out var f24Input1)
                    .WithOutput(f24o, out var f24Output0)
                    .WithHitPolicy(HitPolicyEnum.OutputOrder)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f24Input0, "< 5")
                      .And(f24Input1, "1")
                      .Then(f24Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f24Input0, "<= 5")
                      .And(f24Input1, "2")
                      .Then(f24Output0, "\"b\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f24Input0, "5")
                      .And(f24Input1, "1")
                      .Then(f24Output0, "\"c\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f24Input0, "5")
                      .Then(f24Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f24Input0, "6")
                      .Then(f24Output0, "\"d\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f24Input0, ">= 6")
                      .And(f24Input1, "2")
                      .Then(f24Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f24Input0, ">= 6")
                      .And(f24Input1, "1")
                      .Then(f24Output0, "")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f24Input1, "3")
                      .Then(f24Output0, "\"c\"")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f24Input0, "9")
                      .And(f24Input1, "1")
                      .Then(f24Output0, "\"a\"")
                      )
                   .Requires(f24a)
                   .Requires(f24b)
                 , out var f24OutputOrder)
              .Build();

            //------------------------------------
            //hitpolicy_Priority.dmn
            //------------------------------------

            Hitpolicy_Priority = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f25a)
              .WithInput<Int32>("b", out var f25b)
              .WithVariable<String>("o", out var f25o)

              .WithTableDecision("Priority", table =>
                 table
                    .WithInput(f25a, out var f25Input0)
                    .WithInput(f25b, out var f25Input1)
                    .WithOutput(f25o, out var f25Output0, "b", "a", "c", "d")
                    .WithHitPolicy(HitPolicyEnum.Priority)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f25Input0, "< 5")
                      .And(f25Input1, "1")
                      .Then(f25Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f25Input0, "<= 5")
                      .And(f25Input1, "2")
                      .Then(f25Output0, "\"b\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f25Input0, "5")
                      .And(f25Input1, "1")
                      .Then(f25Output0, "\"c\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f25Input0, "5")
                      .Then(f25Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f25Input0, "6")
                      .Then(f25Output0, "\"d\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f25Input0, ">= 6")
                      .And(f25Input1, "2")
                      .Then(f25Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f25Input0, ">= 6")
                      .And(f25Input1, "1")
                      .Then(f25Output0, "")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f25Input1, "3")
                      .Then(f25Output0, "\"c\"")
                      )
                   .Requires(f25a)
                   .Requires(f25b)
                 , out var f25Priority)
              .Build();

            //------------------------------------
            //hitpolicy_Priority_NoOutWithAllowed.dmn
            //------------------------------------

            Hitpolicy_Priority_NoOutWithAllowed = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f26a)
              .WithInput<Int32>("b", out var f26b)
              .WithVariable<String>("o", out var f26o)

              .WithTableDecision("Priority", table =>
                 table
                    .WithInput(f26a, out var f26Input0)
                    .WithInput(f26b, out var f26Input1)
                    .WithOutput(f26o, out var f26Output0)
                    .WithHitPolicy(HitPolicyEnum.Priority)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f26Input0, "< 5")
                      .And(f26Input1, "1")
                      .Then(f26Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f26Input0, "<= 5")
                      .And(f26Input1, "2")
                      .Then(f26Output0, "\"b\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f26Input0, "5")
                      .And(f26Input1, "1")
                      .Then(f26Output0, "\"c\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f26Input0, "5")
                      .Then(f26Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f26Input0, "6")
                      .Then(f26Output0, "\"d\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f26Input0, ">= 6")
                      .And(f26Input1, "2")
                      .Then(f26Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f26Input0, ">= 6")
                      .And(f26Input1, "1")
                      .Then(f26Output0, "")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f26Input1, "3")
                      .Then(f26Output0, "\"c\"")
                      )
                   .Requires(f26a)
                   .Requires(f26b)
                 , out var f26Priority)
              .Build();

            //------------------------------------
            //hitpolicy_RuleOrder.dmn
            //------------------------------------

            Hitpolicy_RuleOrder = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f27a)
              .WithInput<Int32>("b", out var f27b)
              .WithVariable<String>("o", out var f27o)

              .WithTableDecision("RuleOrder", table =>
                 table
                    .WithInput(f27a, out var f27Input0)
                    .WithInput(f27b, out var f27Input1)
                    .WithOutput(f27o, out var f27Output0, "b", "a", "c", "d")
                    .WithHitPolicy(HitPolicyEnum.RuleOrder)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f27Input0, "< 5")
                      .And(f27Input1, "1")
                      .Then(f27Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-2", r => r
                      .When(f27Input0, "<= 5")
                      .And(f27Input1, "2")
                      .Then(f27Output0, "\"b\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f27Input0, "5")
                      .And(f27Input1, "1")
                      .Then(f27Output0, "\"c\"")
                      )
                    .WithRule("row-816543858-4", r => r
                      .When(f27Input0, "5")
                      .Then(f27Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-5", r => r
                      .When(f27Input0, "6")
                      .Then(f27Output0, "\"d\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f27Input0, ">= 6")
                      .And(f27Input1, "2")
                      .Then(f27Output0, "\"a\"")
                      )
                    .WithRule("row-816543858-7", r => r
                      .When(f27Input0, ">= 6")
                      .And(f27Input1, "1")
                      .Then(f27Output0, "")
                      )
                    .WithRule("row-816543858-13", r => r
                      .When(f27Input1, "3")
                      .Then(f27Output0, "\"c\"")
                      )
                    .WithRule("row-200213824-1", r => r
                      .When(f27Input0, "9")
                      .And(f27Input1, "1")
                      .Then(f27Output0, "\"a\"")
                      )
                   .Requires(f27a)
                   .Requires(f27b)
                 , out var f27RuleOrder)
              .Build();

            //------------------------------------
            //hitpolicy_Unique.dmn
            //------------------------------------

            Hitpolicy_Unique = new DmnDefinitionBuilder()
              .WithInput<Int32>("a", out var f28a)
              .WithInput<Int32>("b", out var f28b)
              .WithVariable<String>("o", out var f28o)

              .WithTableDecision("Unique", table =>
                 table
                    .WithInput(f28a, out var f28Input0)
                    .WithInput(f28b, out var f28Input1)
                    .WithOutput(f28o, out var f28Output0)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-816543858-1", r => r
                      .When(f28Input0, "< 5")
                      .And(f28Input1, "1")
                      .Then(f28Output0, "\"<5 1\"")
                      )
                    .WithRule("row-816543858-2", "err not uniqe for 5 - 2", r => r
                      .When(f28Input0, "<= 5")
                      .And(f28Input1, "2")
                      .Then(f28Output0, "\"<=5 2\"")
                      )
                    .WithRule("row-816543858-3", r => r
                      .When(f28Input0, "5")
                      .And(f28Input1, "1")
                      .Then(f28Output0, "\"5 1\"")
                      )
                    .WithRule("row-816543858-4", "err not uniqe for 5 - 2", r => r
                      .When(f28Input0, "5")
                      .And(f28Input1, "2")
                      .Then(f28Output0, "\"5 2\"")
                      )
                    .WithRule("row-816543858-5", "err not unique for 6-3", r => r
                      .When(f28Input0, "6")
                      .Then(f28Output0, "\"6\"")
                      )
                    .WithRule("row-816543858-6", r => r
                      .When(f28Input0, "> 6")
                      .And(f28Input1, "2")
                      .Then(f28Output0, "\">6 2\"")
                      )
                    .WithRule("row-816543858-7", "empty out", r => r
                      .When(f28Input0, "> 6")
                      .And(f28Input1, "1")
                      .Then(f28Output0, "")
                      )
                    .WithRule("row-816543858-13", "err not unique for 6-3", r => r
                      .When(f28Input1, "3")
                      .Then(f28Output0, "\"- 3\"")
                      )
                   .Requires(f28a)
                   .Requires(f28b)
                 , out var f28Unique)
              .Build();

            //------------------------------------
            //parallel.dmn
            //------------------------------------

            Parallel = new DmnDefinitionBuilder()
              .WithInput("numin", out var f29numin)
              .WithInput<String>("str", out var f29str)
              .WithInput<DateTime>("dt", out var f29dt)
              .WithVariable<Int32>("num", out var f29num)
              .WithVariable<String>("o", out var f29o)
              .WithVariable<Int32>("numout", out var f29numout)
              .WithVariable<Int32>("numinout", out var f29numinout)

              .WithExpressionDecision("numin*2 to num", eDecision =>
                   eDecision.Put("numin*2").To(f29num)
                   .Requires(f29numin)
                 , out var f29numin2tonum)

              .WithTableDecision("sfeel", table =>
                 table
                    .WithInput(f29num, out var f29Input0)
                    .WithInput(f29str, out var f29Input1)
                    .WithInput(f29dt, out var f29Input2)
                    .WithOutput(f29o, out var f29Output0)
                    .WithOutput(f29numout, out var f29Output1)
                    .WithOutput(f29numinout, out var f29Output2)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-200213824-2", r => r
                      .When(f29Input0, "6")
                      .And(f29Input1, "\"a\",\"aa\",\"aaa\"")
                      .Then(f29Output0, "\"6\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-3", r => r
                      .When(f29Input0, "< 5")
                      .And(f29Input1, "\"b\"")
                      .Then(f29Output0, "\"<5\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-4", r => r
                      .When(f29Input0, "<= 4")
                      .And(f29Input1, "\"c\"")
                      .Then(f29Output0, "\"<=4\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-5", r => r
                      .When(f29Input0, "> 5")
                      .And(f29Input1, "\"d\"")
                      .Then(f29Output0, "\">5\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-6", r => r
                      .When(f29Input0, ">= 7")
                      .And(f29Input1, "\"e\"")
                      .Then(f29Output0, "\">=7\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-7", r => r
                      .When(f29Input0, "[2..5]")
                      .And(f29Input1, "\"f\"")
                      .Then(f29Output0, "\"[2..5]\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-8", r => r
                      .When(f29Input0, "[2..5[")
                      .And(f29Input1, "\"g\"")
                      .Then(f29Output0, "\"[2..5[\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-9", r => r
                      .When(f29Input0, "[2..5)")
                      .And(f29Input1, "\"h\"")
                      .Then(f29Output0, "\"[2..5)\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-10", r => r
                      .When(f29Input0, "]2..5]")
                      .And(f29Input1, "\"i\"")
                      .Then(f29Output0, "\"]2..5]\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-11", r => r
                      .When(f29Input0, "]2..5[")
                      .And(f29Input1, "\"j\"")
                      .Then(f29Output0, "\"]2..5[\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-12", r => r
                      .When(f29Input0, "]2..5)")
                      .And(f29Input1, "\"k\"")
                      .Then(f29Output0, "\"]2..5)\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-13", r => r
                      .When(f29Input0, "(2..5]")
                      .And(f29Input1, "\"l\"")
                      .Then(f29Output0, "\"(2..5]\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-14", r => r
                      .When(f29Input0, "(2..5[")
                      .And(f29Input1, "\"m\"")
                      .Then(f29Output0, "\"(2..5[\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-15", r => r
                      .When(f29Input0, "(2..5)")
                      .And(f29Input1, "\"n\"")
                      .Then(f29Output0, "\"(2..5)\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-16", r => r
                      .When(f29Input0, "not(6)")
                      .And(f29Input1, "\"o\"")
                      .Then(f29Output0, "\"not(6)\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-17", r => r
                      .When(f29Input0, "not(<=5)")
                      .And(f29Input1, "\"p\"")
                      .Then(f29Output0, "\"not(<=5)\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-18", r => r
                      .When(f29Input0, "not(>4)")
                      .And(f29Input1, "\"q\"")
                      .Then(f29Output0, "\"not(>4)\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-19", r => r
                      .When(f29Input0, "not([2..5])")
                      .And(f29Input1, "\"r\"")
                      .Then(f29Output0, "\"not([2..5])\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-20", r => r
                      .When(f29Input0, "not((2..5))")
                      .And(f29Input1, "\"s\"")
                      .Then(f29Output0, "\"not((2..5))\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-24", r => r
                      .When(f29Input0, "-10")
                      .And(f29Input1, "not(\"b\",\"c\",\"q\",\"o\",\"r\",\"s\",\"v\")")
                      .Then(f29Output0, "\"1\"")
                      .And(f29Output1, "")
                      .And(f29Output2, "")
                      )
                    .WithRule("row-200213824-29", r => r
                      .When(f29Input0, "<0")
                      .And(f29Input1, "not(\"b\",\"c\",\"q\",\"o\",\"r\",\"s\",\"v\")")
                      .And(f29Input2, ">date(str)")
                      .Then(f29Output0, "str")
                      .And(f29Output1, "num*2")
                      .And(f29Output2, "numin")
                      )
                   .Requires(f29numin)
                   .Requires(f29str)
                   .Requires(f29dt)
                   .Requires(f29numin2tonum)
                 , out var f29sfeel)
              .Build();

            //------------------------------------
            //sfeel.dmn
            //------------------------------------

            Sfeel = new DmnDefinitionBuilder()
              .WithInput<Int32>("num", out var f30num)
              .WithInput<String>("str", out var f30str)
              .WithInput<DateTime>("dt", out var f30dt)
              .WithVariable<String>("o", out var f30o)

              .WithTableDecision("sfeel", table =>
                 table
                    .WithInput(f30num, out var f30Input0)
                    .WithInput(f30str, out var f30Input1)
                    .WithInput(f30dt, out var f30Input2)
                    .WithOutput(f30o, out var f30Output0)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-200213824-2", r => r
                      .When(f30Input0, "6")
                      .And(f30Input1, "\"a\",\"aa\",\"aaa\"")
                      .Then(f30Output0, "\"6\"")
                      )
                    .WithRule("row-200213824-3", r => r
                      .When(f30Input0, "< 5")
                      .And(f30Input1, "\"b\"")
                      .Then(f30Output0, "\"<5\"")
                      )
                    .WithRule("row-200213824-4", r => r
                      .When(f30Input0, "<= 4")
                      .And(f30Input1, "\"c\"")
                      .Then(f30Output0, "\"<=4\"")
                      )
                    .WithRule("row-200213824-5", r => r
                      .When(f30Input0, "> 5")
                      .And(f30Input1, "\"d\"")
                      .Then(f30Output0, "\">5\"")
                      )
                    .WithRule("row-200213824-6", r => r
                      .When(f30Input0, ">= 7")
                      .And(f30Input1, "\"e\"")
                      .Then(f30Output0, "\">=7\"")
                      )
                    .WithRule("row-200213824-7", r => r
                      .When(f30Input0, "[2..5]")
                      .And(f30Input1, "\"f\"")
                      .Then(f30Output0, "\"[2..5]\"")
                      )
                    .WithRule("row-200213824-8", r => r
                      .When(f30Input0, "[2..5[")
                      .And(f30Input1, "\"g\"")
                      .Then(f30Output0, "\"[2..5[\"")
                      )
                    .WithRule("row-200213824-9", r => r
                      .When(f30Input0, "[2..5)")
                      .And(f30Input1, "\"h\"")
                      .Then(f30Output0, "\"[2..5)\"")
                      )
                    .WithRule("row-200213824-10", r => r
                      .When(f30Input0, "]2..5]")
                      .And(f30Input1, "\"i\"")
                      .Then(f30Output0, "\"]2..5]\"")
                      )
                    .WithRule("row-200213824-11", r => r
                      .When(f30Input0, "]2..5[")
                      .And(f30Input1, "\"j\"")
                      .Then(f30Output0, "\"]2..5[\"")
                      )
                    .WithRule("row-200213824-12", r => r
                      .When(f30Input0, "]2..5)")
                      .And(f30Input1, "\"k\"")
                      .Then(f30Output0, "\"]2..5)\"")
                      )
                    .WithRule("row-200213824-13", r => r
                      .When(f30Input0, "(2..5]")
                      .And(f30Input1, "\"l\"")
                      .Then(f30Output0, "\"(2..5]\"")
                      )
                    .WithRule("row-200213824-14", r => r
                      .When(f30Input0, "(2..5[")
                      .And(f30Input1, "\"m\"")
                      .Then(f30Output0, "\"(2..5[\"")
                      )
                    .WithRule("row-200213824-15", r => r
                      .When(f30Input0, "(2..5)")
                      .And(f30Input1, "\"n\"")
                      .Then(f30Output0, "\"(2..5)\"")
                      )
                    .WithRule("row-200213824-16", r => r
                      .When(f30Input0, "not(6)")
                      .And(f30Input1, "\"o\"")
                      .Then(f30Output0, "\"not(6)\"")
                      )
                    .WithRule("row-200213824-17", r => r
                      .When(f30Input0, "not(<=5)")
                      .And(f30Input1, "\"p\"")
                      .Then(f30Output0, "\"not(<=5)\"")
                      )
                    .WithRule("row-200213824-18", r => r
                      .When(f30Input0, "not(>4)")
                      .And(f30Input1, "\"q\"")
                      .Then(f30Output0, "\"not(>4)\"")
                      )
                    .WithRule("row-200213824-19", r => r
                      .When(f30Input0, "not([2..5])")
                      .And(f30Input1, "\"r\"")
                      .Then(f30Output0, "\"not([2..5])\"")
                      )
                    .WithRule("row-200213824-20", r => r
                      .When(f30Input0, "not((2..5))")
                      .And(f30Input1, "\"s\"")
                      .Then(f30Output0, "\"not((2..5))\"")
                      )
                    .WithRule("row-200213824-21", r => r
                      .When(f30Input0, "6,8,3")
                      .And(f30Input1, "\"t\"")
                      .Then(f30Output0, "\"6,8,3\"")
                      )
                    .WithRule("row-200213824-22", r => r
                      .When(f30Input0, "4,[6..9),11")
                      .And(f30Input1, "\"u\"")
                      .Then(f30Output0, "\"4,[6..9),11\"")
                      )
                    .WithRule("row-200213824-23", r => r
                      .When(f30Input0, "not(4,[6..9),11)")
                      .And(f30Input1, "\"v\"")
                      .Then(f30Output0, "\"not(4,[6..9),11)\"")
                      )
                    .WithRule("row-200213824-24", r => r
                      .When(f30Input0, "-10")
                      .And(f30Input1, "not(\"b\",\"c\",\"q\",\"o\",\"r\",\"s\",\"v\")")
                      .Then(f30Output0, "\"1\"")
                      )
                    .WithRule("row-200213824-25", r => r
                      .When(f30Input1, "\"dt1\"")
                      .And(f30Input2, "<date(\"2018-01-23\")")
                      .Then(f30Output0, "\"<date(2018-01-23)\"")
                      )
                    .WithRule("row-200213824-26", r => r
                      .When(f30Input1, "\"dt2\"")
                      .And(f30Input2, ">=date and time(\"2018-01-23T15:30\")")
                      .Then(f30Output0, "\">=date and time(2018-01-23T15:30)\"")
                      )
                    .WithRule("row-200213824-27", r => r
                      .When(f30Input1, "\"dt3\"")
                      .And(f30Input2, "time(\"13:00\")")
                      .Then(f30Output0, "\"time(13:00)\"")
                      )
                    .WithRule("row-200213824-28", r => r
                      .When(f30Input1, "\"dt4\"")
                      .And(f30Input2, ">(date(\"2018-01-23\")+duration(\"P3Y\"))")
                      .Then(f30Output0, "\">(date(2018-01-23)+duration(P3Y))\"")
                      )
                    .WithRule("row-200213824-29", r => r
                      .When(f30Input0, "-20")
                      .And(f30Input1, "not(\"b\",\"c\",\"q\",\"o\",\"r\",\"s\",\"v\")")
                      .And(f30Input2, ">date(str)")
                      .Then(f30Output0, "\">date(str)\"")
                      )
                   .Requires(f30num)
                   .Requires(f30str)
                   .Requires(f30dt)
                 , out var f30sfeel)
              .Build();

            //------------------------------------
            //test.dmn
            //------------------------------------

            Test = new DmnDefinitionBuilder()
              .WithInput("Age", out var f31Age)
              .WithInput<Int32>("Pocet", out var f31Pocet)
              .WithInput("Rano", out var f31Rano)
              .WithInput("Greeting", out var f31Greeting)
              .WithInput("Test", out var f31Test)
              .WithInput("Suffix", out var f31Suffix)
              .WithVariable<Int32>("age10", out var f31age10)
              .WithVariable<Int32>("Age2", out var f31Age2)
              .WithVariable<String>("Category", out var f31Category)
              .WithVariable<Boolean>("Eligible", out var f31Eligible)
              .WithVariable<Int32>("Tout", out var f31Tout)
              .WithVariable<Int32>("Amount", out var f31Amount)
              .WithVariable<String>("CategoryExt", out var f31CategoryExt)

              .WithExpressionDecision("Age +10", eDecision =>
                   eDecision.Put("Age+10").To(f31age10)
                   .Requires(f31Age)
                 , out var f31Age10)

              .WithExpressionDecision("Double (Age+10)", eDecision =>
                   eDecision.Put("age10*2").To(f31Age2)
                   .Requires(f31Age)
                   .Requires(f31Age10)
                 , out var f31DoubleAge10)

              .WithTableDecision("MainDT", table =>
                 table
                    .WithInput(f31Pocet, out var f31Input0)
                    .WithInput("Greeting", out var f31Input1)
                    .WithInput("Rano", out var f31Input2)
                    .WithInput("Test", out var f31Input3, "prvni", "druhy", "treti")
                    .WithInput("Age", out var f31Input4)
                    .WithInput("Age2", out var f31Input5)
                    .WithOutput(f31Category, out var f31Output0, "a", "b", "c")
                    .WithOutput(f31Eligible, out var f31Output1)
                    .WithOutput(f31Tout, out var f31Output2)
                    .WithHitPolicy(HitPolicyEnum.First)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-137040852-1", "Rule 1", r => r
                      .When(f31Input0, "5")
                      .And(f31Input1, "\"ahoj\", \"cau\"")
                      .And(f31Input2, "true")
                      .And(f31Input3, "\"druhy\"")
                      .Then(f31Output0, "\"a\"")
                      .And(f31Output1, "")
                      .And(f31Output2, "2")
                      )
                    .WithRule("row-137040852-2", r => r
                      .When(f31Input0, "< 4")
                      .And(f31Input3, "\"prvni\"")
                      .Then(f31Output0, "\"a\"")
                      .And(f31Output1, "")
                      .And(f31Output2, "Age*2")
                      )
                    .WithRule("row-137040852-4", r => r
                      .When(f31Input0, "<= 3")
                      .And(f31Input1, "not(\"sss\", \"www\")")
                      .Then(f31Output0, "\"c\"")
                      .And(f31Output1, "true")
                      .And(f31Output2, "")
                      )
                    .WithRule("row-137040852-3", r => r
                      .When(f31Input0, "]4..7]")
                      .And(f31Input1, "not(\"po\")")
                      .And(f31Input2, "false")
                      .Then(f31Output0, "\"b\"")
                      .And(f31Output1, "false")
                      .And(f31Output2, "")
                      )
                    .WithRule("row-137040852-6", r => r
                      .When(f31Input0, "[2..6]")
                      .Then(f31Output0, "\"b\"")
                      .And(f31Output1, "")
                      .And(f31Output2, "")
                      )
                    .WithRule("row-137040852-5", r => r
                      .When(f31Input0, "]3..4]")
                      .Then(f31Output0, "\"b\"")
                      .And(f31Output1, "")
                      .And(f31Output2, "")
                      )
                    .WithRule("row-137040852-7", r => r
                      .When(f31Input0, "43")
                      .And(f31Input5, ">30")
                      .Then(f31Output0, "\"a\"")
                      .And(f31Output1, "false")
                      .And(f31Output2, "")
                      )
                    .WithRule("row-137040852-12", "Fallback", r => r
                      .Always()
                      .Then(f31Output0, "\"c\"")
                      .And(f31Output1, "false")
                      .And(f31Output2, "")
                      )
                   .Requires(f31Age)
                   .Requires(f31Pocet)
                   .Requires(f31Greeting)
                   .Requires(f31Rano)
                   .Requires(f31Test)
                   .Requires(f31DoubleAge10)
                 , out var f31MainDT)

              .WithExpressionDecision("Ensure Eligible", eDecision =>
                   eDecision.Put("Eligible==null?false:Eligible").To(f31Eligible)
                   .Requires(f31Age)
                   .Requires(f31Pocet)
                   .Requires(f31Greeting)
                   .Requires(f31Rano)
                   .Requires(f31Test)
                   .Requires(f31MainDT)
                 , out var f31EnsureEligible)

              .WithTableDecision("Secondary DT", table =>
                 table
                    .WithInput(f31Eligible, out var f31Input0)
                    .WithInput(f31Category, out var f31Input1, "a", "b", "c")
                    .WithOutput(f31Amount, out var f31Output0)
                    .WithHitPolicy(HitPolicyEnum.Unique)
                    .WithAggregation(CollectHitPolicyAggregationEnum.List)
                    .WithRule("row-137040852-8", r => r
                      .When(f31Input0, "false")
                      .Then(f31Output0, "0")
                      )
                    .WithRule("row-137040852-9", r => r
                      .When(f31Input1, "\"a\"")
                      .Then(f31Output0, "100")
                      )
                    .WithRule("row-137040852-10", r => r
                      .When(f31Input1, "\"b\"")
                      .Then(f31Output0, "200")
                      )
                    .WithRule("row-137040852-11", r => r
                      .When(f31Input1, "\"c\"")
                      .Then(f31Output0, "300")
                      )
                   .Requires(f31Age)
                   .Requires(f31Pocet)
                   .Requires(f31Greeting)
                   .Requires(f31Rano)
                   .Requires(f31Test)
                   .Requires(f31EnsureEligible)
                 , out var f31SecondaryDT)

              .WithExpressionDecision("Category + suffix", eDecision =>
                   eDecision.Put("Category+Suffix").To(f31CategoryExt)
                   .Requires(f31Age)
                   .Requires(f31Pocet)
                   .Requires(f31Greeting)
                   .Requires(f31Rano)
                   .Requires(f31Test)
                   .Requires(f31Suffix)
                   .Requires(f31MainDT)
                 , out var f31Categorysuffix)
              .Build();

            Files["allowedValues.dmn"] = AllowedValues;
            Files["datatypes.dmn"] = Datatypes;
            Files["dynamictypes.dmn"] = Dynamictypes;
            Files["hitpolicy_Any.dmn"] = Hitpolicy_Any;
            Files["hitpolicy_Collect_Count.dmn"] = Hitpolicy_Collect_Count;
            Files["hitpolicy_Collect_CountBool.dmn"] = Hitpolicy_Collect_CountBool;
            Files["hitpolicy_Collect_CountStr.dmn"] = Hitpolicy_Collect_CountStr;
            Files["hitpolicy_Collect_List.dmn"] = Hitpolicy_Collect_List;
            Files["hitpolicy_Collect_Max.dmn"] = Hitpolicy_Collect_Max;
            Files["hitpolicy_Collect_MaxBool.dmn"] = Hitpolicy_Collect_MaxBool;
            Files["hitpolicy_Collect_Min.dmn"] = Hitpolicy_Collect_Min;
            Files["hitpolicy_Collect_MinBool.dmn"] = Hitpolicy_Collect_MinBool;
            Files["hitpolicy_Collect_Sum.dmn"] = Hitpolicy_Collect_Sum;
            Files["hitpolicy_Collect_SumBool.dmn"] = Hitpolicy_Collect_SumBool;
            Files["hitpolicy_Collect_SumStr.dmn"] = Hitpolicy_Collect_SumStr;
            Files["hitpolicy_First.dmn"] = Hitpolicy_First;
            Files["hitpolicy_MultiOut_Any.dmn"] = Hitpolicy_MultiOut_Any;
            Files["hitpolicy_MultiOut_First.dmn"] = Hitpolicy_MultiOut_First;
            Files["hitpolicy_MultiOut_OutputOrder.dmn"] = Hitpolicy_MultiOut_OutputOrder;
            Files["hitpolicy_MultiOut_Priority.dmn"] = Hitpolicy_MultiOut_Priority;
            Files["hitpolicy_MultiOut_RuleOrder.dmn"] = Hitpolicy_MultiOut_RuleOrder;
            Files["hitpolicy_MultiOut_Unique.dmn"] = Hitpolicy_MultiOut_Unique;
            Files["hitpolicy_OutputOrder.dmn"] = Hitpolicy_OutputOrder;
            Files["hitpolicy_OutputOrder_NoOutWithAllowed.dmn"] = Hitpolicy_OutputOrder_NoOutWithAllowed;
            Files["hitpolicy_Priority.dmn"] = Hitpolicy_Priority;
            Files["hitpolicy_Priority_NoOutWithAllowed.dmn"] = Hitpolicy_Priority_NoOutWithAllowed;
            Files["hitpolicy_RuleOrder.dmn"] = Hitpolicy_RuleOrder;
            Files["hitpolicy_Unique.dmn"] = Hitpolicy_Unique;
            Files["parallel.dmn"] = Parallel;
            Files["sfeel.dmn"] = Sfeel;
            Files["test.dmn"] = Test;
        }
    }

}
