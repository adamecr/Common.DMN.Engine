using System.Linq;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.common.compositeItems;

/// <summary>
/// Container for the items (sub-nodes) in the tree.
/// Defines <see cref="Title"/> of the node and it's child <see cref="Items"/>
/// </summary>
public class CompositeItemsContainer
{
    /// <summary>
    /// Title of the container (node)
    /// </summary>
    public string Title { get; }
    /// <summary>
    /// Child items of the container (sub-nodes)
    /// </summary>
    public ItemWithTemplateKey[] Items { get; }

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="title">Title of the container (node)</param>
    /// <param name="items">Child items of the container (sub-nodes)</param>
    /// <param name="dataTemplateKey">Optional key of data template to be used to render the <paramref name="items"/></param>
    public CompositeItemsContainer(string title, object[] items, string? dataTemplateKey = null)
    {
        Title = title;
        Items = items.Select(i => new ItemWithTemplateKey(i, dataTemplateKey)).ToArray();

    }
}