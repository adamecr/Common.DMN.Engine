namespace net.adamec.lib.common.dmn.engine.simulator.controls.common.compositeItems;

/// <summary>
/// Item of <see cref="CompositeItemsContainer"/>
/// </summary>
public class ItemWithTemplateKey
{
    /// <summary>
    /// Item of <see cref="CompositeItemsContainer"/>
    /// </summary>
    public object Item { get; }
    /// <summary>
    /// Optional key of data template to be used to render the <see cref="Item"/>
    /// </summary>
    public string? DataTemplateKey { get; }

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="item">Item of <see cref="CompositeItemsContainer"/></param>
    /// <param name="dataTemplateKey">Optional key of data template to be used to render the <paramref name="item"/></param>
    public ItemWithTemplateKey(object item, string? dataTemplateKey)
    {
        Item = item;
        DataTemplateKey = dataTemplateKey;
    }
}