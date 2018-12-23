using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.runtime;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    public class DmnDecisionSingleResult
    {
        private readonly List<DmnExecutionVariable> variables = new List<DmnExecutionVariable>();

        public IReadOnlyList<DmnExecutionVariable> Variables => variables;


        public static DmnDecisionSingleResult operator +(DmnDecisionSingleResult instance, DmnExecutionVariable variable)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));
            if (variable == null)
                throw new ArgumentNullException(nameof(variable));

            instance.variables.Add(variable);

            return instance;
        }

    }
}
