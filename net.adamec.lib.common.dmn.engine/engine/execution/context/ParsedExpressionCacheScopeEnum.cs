namespace net.adamec.lib.common.dmn.engine.engine.execution.context
{
    /// <summary>
    /// Scope of the parsed expression cache
    /// </summary>
    public enum ParsedExpressionCacheScopeEnum
    {
        /// <summary>
        /// Don't cache parsed expressions
        /// </summary>
        None,
        /// <summary>
        /// Cache parsed expressions within the single execution run only
        /// </summary>
        Execution,
        /// <summary>
        /// Cache parsed expressions within execution context only
        /// </summary>
        Context,
        /// <summary>
        /// Cache parsed expressions for definition (cross execution contexts)
        /// </summary>
        Definition,
        /// <summary>
        /// Cache parsed expressions globally (cross definitions and execution contexts)
        /// </summary>
        Global
    }
}