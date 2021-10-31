namespace net.adamec.lib.common.dmn.engine.engine.execution.context
{
    /// <summary>
    /// Execution configuration options
    /// </summary>
    public class DmnExecutionContextOptions : IDmnExecutionContextOptions
    {
        /// <summary>
        /// Flag whether to record snapshots of variables and results during the execution (false by default).
        /// This option can be used for execution tracking/audit and/or debugging
        /// </summary>
        public bool RecordSnapshots { get; set; } = false;
        /// <summary>
        /// Flag whether to evaluate the table rules in parallel (true by default).
        /// This option can be used for performance tuning.
        /// </summary>
        public bool EvaluateTableRulesInParallel { get; set; } = true;
        /// <summary>
        /// Flag whether to evaluate the table outputs for positive rules in parallel (false by default).
        /// This option can be used for performance tuning.
        /// </summary>
        public bool EvaluateTableOutputsInParallel { get; set; } = false;

        /// <summary>
        /// Scope of the parsed expression cache (Cache parsed expressions for definition cross contexts by default)
        /// </summary>
        public ParsedExpressionCacheScopeEnum ParsedExpressionCacheScope { get; set; } = ParsedExpressionCacheScopeEnum.Definition;
    }
}