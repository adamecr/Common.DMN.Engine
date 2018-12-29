namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Decision Table hit policy - the hit policy specifies what the result of the decision table is in cases of overlapping rules, i.e. when more than one rule matches the input data.
    /// </summary>
    /// <remarks>
    /// Decision tables with compound outputs support only the following hit policies: Unique, Any, Priority, First, Output order, Rule order and Collect without operator,
    /// because the collect operator is undefined over multiple outputs. 
    /// For the Priority and Output order hit policies, priority is decided in compound output tables over all the outputs for which output values have been provided.
    /// The priority for each output is specified in the ordered list of output values in decreasing order of priority,
    /// and the overall priority is established by considering the ordered outputs from left to right. 
    /// Outputs for which no output values are provided are not taken into account in the ordering, although their output entries are included in the ordered compound output.
    /// </remarks>
    public enum HitPolicyEnum
    {
        /// <summary>
        /// No overlap is possible and all rules are disjoint. Only a single rule can be matched
        /// Overlapping rules represent an error.
        /// </summary>
        Unique,
        /// <summary>
        /// Multiple (overlapping) rules can match, with different output entries. The first hit by rule order is returned
        /// </summary>
        First,
        /// <summary>
        /// Multiple rules can match, with different output entries. This policy returns the matching rule with the highest output priority.
        ///  Output priorities are specified in the ordered list of output values, in decreasing order of priority. Note that priorities are independent from rule sequence
        /// A P table that omits allowed output values is an error.
        /// </summary>
        Priority,
        /// <summary>
        ///  There may be overlap, but all of the matching rules show equal output entries for each output, so any match can be used.
        ///  If the output entries are non-equal, the hit policy is incorrect and the result is an error.
        /// </summary>
        Any,
        /// <summary>
        /// Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in an arbitrary order as a list.
        /// If an aggregator is specified, the decision table result will only contain a single output entry. The aggregator will generate the output entry from all satisfied rules.
        /// Except for C-count and C-list, the rules must have numeric output values (bool is also allowed - 0=false, 1=true).    
        /// If the Collect hit policy is used with an aggregator, the decision table can only have one output.
        /// </summary>
        Collect,
        /// <summary>
        /// Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in the order of the rules in the decision table.
        /// </summary>
        RuleOrder,
        /// <summary>
        /// Returns all hits in decreasing output priority order. 
        /// Output priorities are specified in the ordered list of output values in decreasing order of priority
        /// </summary>
        OutputOrder
    }
}
