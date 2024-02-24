using Verifone.VIPA.State.Actions;
using Verifone.VIPA.State;

namespace Verifone.VIPA.Controllers
{
    internal class VIPAStateActionControllerImpl : IVipaStateActionController
    {
        public IVipaStateAction GetFinalState()
        {
            return null;
        }

        public IVipaStateAction GetNextAction(IVipaStateAction stateAction)
        {
            return null;
        }

        public IVipaStateAction GetNextAction(VipaWorkflowState state)
        {
            return null;
        }

        public IVipaStateAction GetSpecificAction(VipaWorkflowState state)
        {
            return null;
        }
    }
}
