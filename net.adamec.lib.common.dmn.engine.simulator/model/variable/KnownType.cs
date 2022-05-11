using System;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.definition;

namespace net.adamec.lib.common.dmn.engine.simulator.model.variable;

/// <summary>
/// Wrapper around the known type - the type recognized by <see cref="DmnDefinitionFactory"/>
/// </summary>
public class KnownType
{
    /// <summary>
    /// Array of all <see cref="KnownType"/>s
    /// </summary>
    public static KnownType[] KnownTypes { get; } = DmnDefinitionFactory.DefaultKnowTypes.Select(kv => new KnownType(kv.Key, kv.Value)).ToArray();

    /// <summary>
    /// Name of the know type
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// Data type of the known type
    /// </summary>
    public Type Type { get; }

    /// <summary>
    /// CTOR (private - used by <see cref="KnownTypes"/> initializer)
    /// </summary>
    /// <param name="name">Name of the know type</param>
    /// <param name="type">Data type of the known type</param>
    private KnownType(string name, Type type)
    {
        Name = name;
        Type = type;
    }

    /// <summary>
    /// Get the <see cref="KnownType"/> from data <paramref name="type"/> if it's a known type
    /// </summary>
    /// <param name="type">Type to get the <see cref="KnownType"/> for</param>
    /// <returns><see cref="KnownType"/> from data <paramref name="type"/> if it's a known type, otherwise null</returns>
    public static KnownType? FromType(Type type)
    {
        return KnownTypes.FirstOrDefault(t => t.Type == type);
    }

    /// <summary>
    /// Get the <see cref="KnownType.Name"/> from data <paramref name="type"/> if it's a known type
    /// </summary>
    /// <param name="type">Type to get the <see cref="KnownType.Name"/> for</param>
    /// <returns>Name of known type when the <paramref name="type"/> is known type, otherwise null</returns>
    public static string? NameFromType(Type type)
    {
        return KnownTypes.FirstOrDefault(t => t.Type == type)?.Name;
    }

    /// <summary>
    /// Get the <see cref="KnownType.Type"/> from data type <paramref name="name"/> if it's a known type
    /// </summary>
    /// <param name="name">Name of the known type to get the <see cref="KnownType.Type"/> for</param>
    /// <returns>Data type of known type when the <paramref name="name"/> refers to known type, otherwise null</returns>
    public static Type? TypeFromName(string name)
    {
        return KnownTypes.FirstOrDefault(t => t.Name == name)?.Type;
    }

    /// <summary>
    /// Check whether the data <paramref name="type"/> is a known type
    /// </summary>
    /// <param name="type">Data type to check</param>
    /// <returns>True when <paramref name="type"/> is a known type</returns>
    public static bool IsKnownType(Type type)
    {
        return KnownTypes.Any(t => t.Type == type);
    }
}