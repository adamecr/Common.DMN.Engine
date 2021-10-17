using System;
using System.Collections.Generic;
using System.Linq;

namespace net.adamec.lib.common.dmn.engine.engine.execution.result
{
    /// <summary>
    /// Decision evaluation result (single or multiple)
    /// </summary>
    public class DmnDecisionResult
    {
        /// <summary>
        /// Internal list of results. The first item represents the <see cref="SingleResult"/>
        /// </summary>
        private readonly List<DmnDecisionSingleResult> results = new List<DmnDecisionSingleResult>();
        /// <summary>
        /// List of decision evaluation results. 
        /// </summary>
        /// <remarks>The first item represents the <see cref="SingleResult"/>,
        /// however it's recommended to use the <see cref="SingleResult"/> when expecting the single result.</remarks>
        public IReadOnlyList<DmnDecisionSingleResult> Results => results;
        /// <summary>
        /// Decision evaluation single (first) result variables.
        /// When there is no result, the empty list of <see cref="DmnResultVariable">variables</see> is returned.
        /// </summary>
        public IReadOnlyList<DmnResultVariable> SingleResult =>
            results.Count == 0 ? new List<DmnResultVariable>() : results[0].Variables;

        /// <summary>
        /// Flag whether there is any result available
        /// </summary>
        public bool HasResult => results.Count > 0;
        /// <summary>
        /// Flag whether the decision  has single result
        /// </summary>
        public bool IsSingleResult => results.Count == 1;

        public DmnDecisionResult()
        {
        }

        public DmnDecisionResult(DmnDecisionSingleResult result)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));

            results.Add(result);
        }

        /// <summary>
        /// Adds a single (one) result into the list of results
        /// </summary>
        /// <param name="instance">Decision result</param>
        /// <param name="result">Decision result to add</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentException"><paramref name="instance"/> or <paramref name="result"/> is null</exception>
        public static DmnDecisionResult operator +(DmnDecisionResult instance, DmnDecisionSingleResult result)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (result == null) throw new ArgumentNullException(nameof(result));

            instance.results.Add(result);

            return instance;
        }

        /// <summary>
        /// Clones the decision result
        /// </summary>
        /// <returns>Cloned decision result</returns>
        public DmnDecisionResult Clone()
        {
            var retVal = new DmnDecisionResult();
            retVal.results.AddRange(Results.Select(v => v.Clone()).ToList());
            return retVal;
        }
    }
}
