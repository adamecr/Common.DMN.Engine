using System;
using net.adamec.lib.common.core.logging;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Base class for the elements of DMN definition<see cref="DmnDefinitionBuilder"/>
    /// </summary>
    public abstract class DmnBuilderElement
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected ILogger Logger;

        /// <summary>
        /// All known variables of <see cref="DmnDefinitionBuilder"/>
        /// </summary>
        protected VariableCatalog Variables { get; }

        /// <summary>
        /// All known decisions of <see cref="DmnDefinitionBuilder"/>
        /// </summary>
        protected DecisionCatalog Decisions { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables">Variable catalog of of <see cref="DmnDefinitionBuilder"/></param>
        /// <param name="decisions">Decisions catalog of of <see cref="DmnDefinitionBuilder"/></param>
        protected DmnBuilderElement(VariableCatalog variables, DecisionCatalog decisions)
        {
            Logger = CommonLogging.CreateLogger(GetType());
            Variables = variables ?? throw new ArgumentNullException(nameof(variables));
            Decisions = decisions ?? throw new ArgumentNullException(nameof(decisions));
        }
    }

    /// <summary>
    /// Base class for the buildable elements of DMN definition<see cref="DmnDefinitionBuilder"/>
    /// </summary>
    /// <typeparam name="TBuilder">Type of the builder - "reference" to itself</typeparam>
    /// <typeparam name="TResult">Type of the definition to be built</typeparam>
    public abstract class DmnBuilderElement<TBuilder, TResult> : DmnBuilderElement
        where TBuilder : DmnBuilderElement<TBuilder, TResult> where TResult : class
    {
        /// <summary>
        /// Flag whether the definition has been already built.
        /// </summary>
        /// <remarks>When set to true, the definition can't be modified anymore -
        /// the modification functions will throw <see cref="DmnBuilderException"/> when called</remarks>
        public bool IsBuilt => ResultInternal != null;

        /// <summary>
        /// Internal build result
        /// </summary>
        protected TResult ResultInternal;

        /// <summary>
        /// Build result
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> in case the element is not built yet</exception>
        public TResult Result =>
            ResultInternal ??
            throw Logger.Error<DmnBuilderException>($"{GetType().Name} is not built yet");

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables">Variable catalog of of <see cref="DmnDefinitionBuilder"/></param>
        /// <param name="decisions">Decisions catalog of of <see cref="DmnDefinitionBuilder"/></param>
        protected DmnBuilderElement(VariableCatalog variables, DecisionCatalog decisions) : base(variables, decisions)
        {

        }

        /// <summary>
        /// Builds the builder element and returns the built definition element
        /// </summary>
        /// <returns>Built definition element</returns>
        protected internal abstract TResult Build();

        /// <summary>
        /// Gets built definition element. Calls <see cref="Build"/> first if needed
        /// </summary>
        /// <returns>Built definition element</returns>
        protected internal TResult GetResultOrBuild()
        {
            return IsBuilt ? Result : Build();
        }

        /// <summary>
        /// Gets built definition of given <paramref name="element"/>.
        /// </summary>
        /// <param name="element">Builder element to get the built definition from</param>
        /// <typeparam name="TBuilderElement">Builder element type of <paramref name="element"/></typeparam>
        /// <typeparam name="TBuilderElementResult">Build result type of <paramref name="element"/></typeparam>
        /// <returns>Built definition element</returns>
        protected static TBuilderElementResult GetResultOrBuild<TBuilderElement, TBuilderElementResult>(
            DmnBuilderElement<TBuilderElement, TBuilderElementResult> element)
            where TBuilderElement : DmnBuilderElement<TBuilderElement, TBuilderElementResult>
            where TBuilderElementResult : class
        {
            return element.GetResultOrBuild();
        }
    }
}