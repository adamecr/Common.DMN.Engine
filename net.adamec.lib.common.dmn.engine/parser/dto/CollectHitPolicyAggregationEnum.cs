namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Collect hit policy aggregation type
    /// </summary>
    public enum CollectHitPolicyAggregationEnum
    {
        /// <summary>
        /// None, return list of values
        /// </summary>
        List,
        /// <summary>
        /// The sum of all output values
        /// </summary>
        Sum,
        /// <summary>
        /// The smallest value of all output values
        /// </summary>
        Min,
        /// <summary>
        /// The largest value of all output values
        /// </summary>
        Max,
        /// <summary>
        /// The number of output values
        /// </summary>
        Count
    }
}
