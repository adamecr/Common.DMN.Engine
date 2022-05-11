using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.zoomcontrol;

/// <summary>
/// Zoom content presenter control.
/// </summary>
public sealed class ZoomContentPresenter : ContentPresenter
{
    /// <summary>
    /// Event raised when the content size changes
    /// </summary>
    public event ContentSizeChangedHandler? ContentSizeChanged;

    /// <summary>
    /// Size of the content
    /// </summary>
    private Size contentSize;

    /// <summary>
    /// Size of the content
    /// </summary>
    public Size ContentSize
    {
        get => contentSize;
        private set
        {
            if (contentSize == value) return;

            contentSize = value;
            ContentSizeChanged?.Invoke(this, contentSize);
        }
    }

    /// <summary>
    /// Integer representing "infinite" value
    /// </summary>
    private const int InfiniteSize = 1000000000;
    
    /// <inheritdoc />
    protected override Size MeasureOverride(Size constraint)
    {
        base.MeasureOverride(new Size(double.PositiveInfinity, double.PositiveInfinity));

        return new Size(
            double.IsInfinity(constraint.Width) ? InfiniteSize : constraint.Width,
            double.IsInfinity(constraint.Height) ? InfiniteSize : constraint.Height);
    }

    /// <inheritdoc />
    protected override Size ArrangeOverride(Size arrangeSize)
    {
        var uiElement = VisualChildrenCount > 0 ? VisualTreeHelper.GetChild(this, 0) as UIElement : null;
        if (uiElement is null)
            return arrangeSize;

        ContentSize = uiElement.DesiredSize;
        uiElement.Arrange(new Rect(uiElement.DesiredSize));

        return arrangeSize;
    }
}