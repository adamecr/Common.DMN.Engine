using System;
using System.Collections.Generic;
using System.Linq;
using GraphShape;
using GraphShape.Algorithms;
using GraphShape.Algorithms.Layout;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using QuikGraph;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.algorithm;

/// <summary>
/// Implementation of a layout algorithm factory.
/// </summary>
/// <typeparam name="TVertex">Vertex type. Must be <see cref="DmnElement"/></typeparam>
/// <typeparam name="TEdge">Edge type.</typeparam>
/// <typeparam name="TGraph">Graph type.</typeparam>
public class LayoutAlgorithmFactory<TVertex, TEdge, TGraph> : ILayoutAlgorithmFactory<TVertex, TEdge, TGraph>
    where TVertex : DmnElement
    where TEdge : IEdge<TVertex>
    where TGraph : class, IBidirectionalGraph<TVertex, TEdge>
{
    // ReSharper disable InconsistentNaming
    public const string CircularAlgorithm = "Circular";
    public const string TreeAlgorithm = "Tree";
    public const string FRAlgorithm = "FR";
    public const string BoundedFRAlgorithm = "BoundedFR";
    public const string KKAlgorithm = "KK";
    public const string ISOMAlgorithm = "ISOM";
    public const string LinLogAlgorithm = "LinLog";
    public const string SugiyamaAlgorithm = "Sugiyama";
    public const string CompoundFDPAlgorithm = "CompoundFDP";
    public const string RandomAlgorithm = "Random";
    public const string DmnDiAlgorithm = "DmnDi";
    // ReSharper restore InconsistentNaming


    /// <summary>
    /// Returns the set of available algorithm names
    /// </summary>
    public IEnumerable<string> AlgorithmTypes { get; } = new[]
    {
        DmnDiAlgorithm, TreeAlgorithm, LinLogAlgorithm,CircularAlgorithm, FRAlgorithm, BoundedFRAlgorithm,
        KKAlgorithm, ISOMAlgorithm,  SugiyamaAlgorithm,
        CompoundFDPAlgorithm, RandomAlgorithm
    };

    /// <summary>
    /// Creates the algorithm based on <paramref name="algorithmType"/> (name of the algorithm)
    /// </summary>
    /// <param name="algorithmType">Name of the algorithm</param>
    /// <param name="context">Layout context</param>
    /// <param name="parameters">Layout algorithm parameters</param>
    /// <returns>Layout algorithm or null when the <paramref name="algorithmType"/> is unknown</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="algorithmType"/>, <paramref name="context"/> or context's Graph is null</exception>
    public ILayoutAlgorithm<TVertex, TEdge, TGraph>? CreateAlgorithm(
        string algorithmType,
        ILayoutContext<TVertex, TEdge, TGraph> context,
        ILayoutParameters parameters)
    {
        if (algorithmType is null) throw new ArgumentNullException(nameof(algorithmType));
        if (context is null) throw new ArgumentNullException(nameof(context));
        if (context.Graph is null) return null;

        return CreateAlgorithmInternal(algorithmType, context, parameters);
    }

    /// <summary>
    /// Creates the algorithm based on <paramref name="algorithmType"/> (name of the algorithm)
    /// </summary>
    /// <param name="algorithmType">Name of the algorithm</param>
    /// <param name="context">Layout context</param>
    /// <param name="parameters">Layout algorithm parameters</param>
    /// <returns>Layout algorithm or null when the <paramref name="algorithmType"/> is unknown</returns>
    private static ILayoutAlgorithm<TVertex, TEdge, TGraph>? CreateAlgorithmInternal(
        string algorithmType,
        ILayoutContext<TVertex, TEdge, TGraph> context,
        ILayoutParameters? parameters)
    {
        return context.Mode switch
        {
            LayoutMode.Simple when string.Equals(algorithmType, CircularAlgorithm) =>
                new CircularLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, context.Sizes, parameters as CircularLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, TreeAlgorithm) =>
                new SimpleTreeLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, context.Sizes, parameters as SimpleTreeLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, FRAlgorithm) =>
                new FRLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, parameters as FRLayoutParametersBase),
            LayoutMode.Simple when string.Equals(algorithmType, BoundedFRAlgorithm) =>
                new FRLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, parameters as BoundedFRLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, KKAlgorithm) =>
                new KKLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, parameters as KKLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, ISOMAlgorithm) =>
                new ISOMLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, parameters as ISOMLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, LinLogAlgorithm) =>
                new LinLogLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, parameters as LinLogLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, SugiyamaAlgorithm) =>
                new SugiyamaLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, context.Sizes, parameters as SugiyamaLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, CompoundFDPAlgorithm) =>
                new CompoundFDPLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, context.Sizes,
                    new Dictionary<TVertex, Thickness>(), new Dictionary<TVertex, CompoundVertexInnerLayoutType>(), parameters as CompoundFDPLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, RandomAlgorithm) =>
                new RandomLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, context.Sizes,
                    new Dictionary<TVertex, RandomVertexType>(), parameters as RandomLayoutParameters),
            LayoutMode.Simple when string.Equals(algorithmType, DmnDiAlgorithm) =>
                new DmnDiLayoutAlgorithm<TVertex, TEdge, TGraph>(context.Graph, context.Positions, context.Sizes, parameters as DmnDiLayoutParameters),

            LayoutMode.Simple => null,

            LayoutMode.Compound when context is ICompoundLayoutContext<TVertex, TEdge, TGraph> compoundContext && string.Equals(algorithmType, CompoundFDPAlgorithm) =>
                new CompoundFDPLayoutAlgorithm<TVertex, TEdge, TGraph>(compoundContext.Graph, compoundContext.Positions, compoundContext.Sizes,
                    compoundContext.VerticesBorders, compoundContext.LayoutTypes, parameters as CompoundFDPLayoutParameters),
            _ => null
        };
    }

    /// <summary>
    /// Creates the <see cref="ILayoutParameters">layout parameters</see> for know algorithm.
    /// Clones existing <paramref name="parameters"/> if possible or create the default ones
    /// </summary>
    /// <param name="algorithmType">Name of the algorithm</param>
    /// <param name="parameters">Existing layout parameters</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public ILayoutParameters? CreateParameters(string algorithmType, ILayoutParameters parameters)
    {
        if (algorithmType is null) throw new ArgumentNullException(nameof(algorithmType));

        return algorithmType switch
        {
            CircularAlgorithm => parameters.CreateNewParameters<CircularLayoutParameters>(),
            TreeAlgorithm => parameters.CreateNewParameters<SimpleTreeLayoutParameters>(),
            FRAlgorithm => parameters.CreateNewParameters<FreeFRLayoutParameters>(),
            BoundedFRAlgorithm => parameters.CreateNewParameters<BoundedFRLayoutParameters>(),
            KKAlgorithm => parameters.CreateNewParameters<KKLayoutParameters>(),
            ISOMAlgorithm => parameters.CreateNewParameters<ISOMLayoutParameters>(),
            LinLogAlgorithm => parameters.CreateNewParameters<LinLogLayoutParameters>(),
            SugiyamaAlgorithm => parameters.CreateNewParameters<SugiyamaLayoutParameters>(),
            CompoundFDPAlgorithm => parameters.CreateNewParameters<CompoundFDPLayoutParameters>(),
            RandomAlgorithm => parameters.CreateNewParameters<RandomLayoutParameters>(),
            DmnDiAlgorithm => parameters.CreateNewParameters<DmnDiLayoutParameters>(),
            _ => null
        };
    }

    /// <summary>
    /// Checks whether the <paramref name="algorithmType"/> (algorithm name) is valid (known)
    /// </summary>
    /// <param name="algorithmType">Algorithm name to check</param>
    /// <returns>True is the <paramref name="algorithmType"/> is known, otherwise false</returns>
    public bool IsValidAlgorithm(string algorithmType)
    {
        return AlgorithmTypes.Contains(algorithmType);
    }

    /// <summary>
    /// Gets the algorithm name from <paramref name="algorithm"/> object
    /// </summary>
    /// <param name="algorithm">Algorithm to check</param>
    /// <returns>Algorithm name</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="algorithm"/> is null</exception>
    public string GetAlgorithmType(ILayoutAlgorithm<TVertex, TEdge, TGraph> algorithm)
    {
        return algorithm switch
        {
            null => throw new ArgumentNullException(nameof(algorithm)),
            CircularLayoutAlgorithm<TVertex, TEdge, TGraph> => CircularAlgorithm,
            SimpleTreeLayoutAlgorithm<TVertex, TEdge, TGraph> => TreeAlgorithm,
            FRLayoutAlgorithm<TVertex, TEdge, TGraph> { Parameters: BoundedFRLayoutParameters } => BoundedFRAlgorithm,
            FRLayoutAlgorithm<TVertex, TEdge, TGraph> => FRAlgorithm,
            KKLayoutAlgorithm<TVertex, TEdge, TGraph> => KKAlgorithm,
            ISOMLayoutAlgorithm<TVertex, TEdge, TGraph> => ISOMAlgorithm,
            LinLogLayoutAlgorithm<TVertex, TEdge, TGraph> => LinLogAlgorithm,
            SugiyamaLayoutAlgorithm<TVertex, TEdge, TGraph> => SugiyamaAlgorithm,
            CompoundFDPLayoutAlgorithm<TVertex, TEdge, TGraph> => CompoundFDPAlgorithm,
            RandomLayoutAlgorithm<TVertex, TEdge, TGraph> => RandomAlgorithm,
            DmnDiLayoutAlgorithm<TVertex, TEdge, TGraph> => DmnDiAlgorithm,
            _ => string.Empty
        };
    }

    /// <summary>
    /// Checks whether the given <paramref name="algorithmType">algorithm</paramref> requires the edge routing
    /// </summary>
    /// <param name="algorithmType">Name of the algorithm</param>
    /// <returns>True when <paramref name="algorithmType"/> requires the edge routing</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="algorithmType"/> is null</exception>
    public bool NeedEdgeRouting(string algorithmType)
    {
        if (algorithmType is null) throw new ArgumentNullException(nameof(algorithmType));

        return IsValidAlgorithm(algorithmType) && algorithmType != SugiyamaAlgorithm;
    }

    /// <summary>
    /// Checks whether the given <paramref name="algorithmType">algorithm</paramref> requires the overlap removal
    /// </summary>
    /// <param name="algorithmType">Name of the algorithm</param>
    /// <returns>True when <paramref name="algorithmType"/> requires the overlap removal</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="algorithmType"/> is null</exception>
    public bool NeedOverlapRemoval(string algorithmType)
    {
        if (algorithmType is null) throw new ArgumentNullException(nameof(algorithmType));

        return IsValidAlgorithm(algorithmType)
               && algorithmType != CircularAlgorithm
               && algorithmType != TreeAlgorithm
               && algorithmType != SugiyamaAlgorithm
               && algorithmType != CompoundFDPAlgorithm;
    }
}