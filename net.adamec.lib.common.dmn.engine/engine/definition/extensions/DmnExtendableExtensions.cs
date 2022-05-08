using System;
using System.Linq;

namespace net.adamec.lib.common.dmn.engine.engine.definition.extensions
{
    /// <summary>
    /// <see cref="IDmnExtendable"/> extension methods to access the <see cref="IDmnExtendable.Extensions"/>
    /// </summary>
    public static class DmnExtendableExtensions
    {
        /// <summary>
        /// Get all extensions of type <typeparamref name="TExtension"/> from <paramref name="element"/>
        /// </summary>
        /// <typeparam name="TExtension">Type of the extension</typeparam>
        /// <param name="element">DMN element</param>
        /// <returns>All extensions of type <typeparamref name="TExtension"/> from <paramref name="element"/> or empty array when no such extension is found</returns>
        public static TExtension[] GetExtensions<TExtension>(this IDmnExtendable element)
        {
            return element?.Extensions is null ? Array.Empty<TExtension>() : element.Extensions.Where(e => e is TExtension).Cast<TExtension>().ToArray();
        }

        /// <summary>
        /// Get the first extension of type <typeparamref name="TExtension"/> from <paramref name="element"/>
        /// </summary>
        /// <typeparam name="TExtension">Type of the extension</typeparam>
        /// <param name="element">DMN element</param>
        /// <returns>The first extension of type <typeparamref name="TExtension"/> from <paramref name="element"/> or default value of <typeparamref name="TExtension"/></returns>
        public static TExtension GetExtension<TExtension>(this IDmnExtendable element)
        {
            return element?.Extensions is null ? default : element.Extensions.Where(e => e is TExtension).Cast<TExtension>().FirstOrDefault();
        }

        /// <summary>
        /// Check whether <paramref name="element"/> has the extension of type <typeparamref name="TExtension"/>
        /// </summary>
        /// <typeparam name="TExtension">Type of the extension</typeparam>
        /// <param name="element">DMN element</param>
        /// <returns>True when <paramref name="element"/> has the extension of type <typeparamref name="TExtension"/> otherwise false</returns>
        public static bool HasExtension<TExtension>(this IDmnExtendable element)
        {
            return !(element?.Extensions is null) && element.Extensions.Any(e => e is TExtension);
        }

        /// <summary>
        /// Adds <paramref name="extension"/> to <paramref name="element"/>
        /// </summary>
        /// <param name="element">DMN element to add the extension to</param>
        /// <param name="extension">Extension to add</param>
        /// <exception cref="ArgumentNullException">When <paramref name="element"/> or <paramref name="extension"/> is null</exception>
        public static void AddExtension(this IDmnExtendable element, object extension)
        {
            if (element is null) throw new ArgumentNullException(nameof(element));
            if (extension is null) throw new ArgumentNullException(nameof(extension));

            element.Extensions?.Add(extension);
        }
    }
}