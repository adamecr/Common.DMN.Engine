namespace net.adamec.lib.common.dmn.engine.simulator.model.element;

/// <summary>
/// Boundaries of the DMN Shape 
/// </summary>
public class ShapeBounds
{
    /// <summary>
    /// Height of the DMN Shape
    /// </summary>
    public int Height { get; set; }
    /// <summary>
    /// Width of the DMN Shape
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// X position of the DMN Shape
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Y position of the DMN Shape
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Flag whether the DMN shape has size (both <see cref="Width"/> and <see cref="Height"/> are set)
    /// </summary>
    public bool HasSize => Width > 0 && Height > 0;

}