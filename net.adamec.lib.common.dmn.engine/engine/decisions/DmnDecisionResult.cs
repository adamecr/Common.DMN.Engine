using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.runtime;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    public class DmnDecisionResult
    {
        private readonly List<DmnDecisionSingleResult> results = new List<DmnDecisionSingleResult>();

        public IReadOnlyList<DmnDecisionSingleResult> Results => results;
        public IReadOnlyList<DmnExecutionVariable> SingleResult => results.Count == 0 ? new List<DmnExecutionVariable>() : results[0].Variables;

        public bool HasResult => results.Count > 0;
        public bool IsSingleResult => results.Count == 1;

        public static DmnDecisionResult operator +(DmnDecisionResult instance, DmnDecisionSingleResult result)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));
            if (result == null)
                throw new ArgumentNullException(nameof(result));

            instance.results.Add(result);

            return instance;
        }
    }
}
