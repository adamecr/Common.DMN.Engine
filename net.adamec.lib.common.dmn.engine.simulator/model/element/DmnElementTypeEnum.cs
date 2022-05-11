namespace net.adamec.lib.common.dmn.engine.simulator.model.element;

/// <summary>
/// The DMN element represented by the DMN graph vertex
/// </summary>
public enum DmnElementTypeEnum
{
    /// <summary>
    /// Unknown element
    /// </summary>
    Unknown,
    /// <summary>
    /// DMN Input
    /// </summary>
    Input,
    /// <summary>
    /// DMN variable that is not Input
    /// </summary>
    NonInputVariable,
    /// <summary>
    /// DMN expression decision
    /// </summary>
    DecisionExpression,
    /// <summary>
    /// DMN decision table
    /// </summary>
    DecisionTable,
    /// <summary>
    /// Unspecified decision
    /// </summary>
    DecisionUnknown,
    
}