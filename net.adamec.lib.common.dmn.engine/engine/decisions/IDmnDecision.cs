using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    public interface IDmnDecision
    {
        string Name { get; }
        List<DmnVariableDefinition> RequiredInputs { get; }
        List<IDmnDecision> RequiredDecisions { get; }
        DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null);
    }
}
