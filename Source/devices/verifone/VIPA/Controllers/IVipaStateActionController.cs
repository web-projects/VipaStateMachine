using Verifone.VIPA.State;
using Verifone.VIPA.State.Actions;

namespace Verifone.VIPA.Controllers
{
    internal interface IVipaStateActionController
    {
        IVipaStateAction GetFinalState();
        IVipaStateAction GetNextAction(IVipaStateAction stateAction);
        IVipaStateAction GetNextAction(VipaWorkflowState state);
        IVipaStateAction GetSpecificAction(VipaWorkflowState state);
    }
}
