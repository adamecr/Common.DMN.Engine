using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.common.compositeItems;

/// <summary>
/// Items source for tree view allowing to mix the items (and sub-items) of different types
/// </summary>
public class CompositeItemsHelper
{
    /// <summary>
    /// List of tree nodes. Creates hierarchy using the <see cref="CompositeItemsContainer"/>
    /// </summary>
    public List<object> Items { get; } = new();


    /// <summary>
    /// Adds the <paramref name="items"/> in the list of tree nodes.
    /// </summary>
    /// <param name="items">Items to added as nodes</param>
    /// <returns></returns>
    public CompositeItemsHelper Add(IEnumerable items)
    {
        // ReSharper disable once RedundantArgumentDefaultValue
        return Add(string.Empty, items, false, true, null);
    }

    /// <summary>
    /// Adds the <paramref name="items"/> in the list of tree nodes.
    /// </summary>
    /// <param name="title">Title of the <see cref="CompositeItemsContainer"/></param>
    /// <param name="items">Items to add either as nodes (<paramref name="mergeItemsOnly"/> is true)
    /// or sub-nodes of <see cref="CompositeItemsContainer"/> with given <paramref name="title"/></param>
    /// <param name="skipIfEmpty">Flag whether to skip creating the <see cref="CompositeItemsContainer"/> for empty <paramref name="items"/></param>
    /// <param name="mergeItemsOnly">If true, the <paramref name="items"/> are added directly as nodes,
    /// otherwise as <see cref="CompositeItemsContainer"/> is created and added as a node and the <paramref name="items"/> are its sub-nodes</param>
    /// <param name="dataTemplateKey">Optional key of data template to be used to render the <paramref name="items"/></param>
    /// <returns></returns>
    public CompositeItemsHelper Add(string title, IEnumerable? items, bool skipIfEmpty = false,
        bool mergeItemsOnly = false, string? dataTemplateKey = null)
    {
        var castItems = items?.Cast<object>().ToArray() ?? Array.Empty<object>();

        if (mergeItemsOnly)
        {
            if (castItems.Length > 0)
            {
                Items.AddRange(castItems);
            }
        }
        else
        {
            if (castItems.Length > 0 || !skipIfEmpty)
            {
                var container = new CompositeItemsContainer(title, castItems, dataTemplateKey);
                Items.Add(container);
            }
        }

        return this;
    }
}