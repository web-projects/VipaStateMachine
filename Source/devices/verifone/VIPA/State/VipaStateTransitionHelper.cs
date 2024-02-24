using static Verifone.VIPA.State.VipaWorkflowState;

namespace Verifone.VIPA.State
{
    internal static class VipaStateTransitionHelper
    {
        private static VipaWorkflowState ComputeUndefinedStateTransition(bool exception) =>
            exception switch
            {
                true => CommandRequest,
                false => Idle
            };

        private static VipaWorkflowState ComputeCommandRequestStateTransition(bool exception) =>
            exception switch
            {
                true => CommandReply,
                false => Idle
            };

        private static VipaWorkflowState ComputeCommandReplyStateTransition(bool exception) =>
            exception switch
            {
                true => Idle,
                false => Idle
            };

        private static VipaWorkflowState ComputeCompleteStateTransition(bool exception) =>
            exception switch
            {
                true => Idle,
                false => Idle
            };

        private static VipaWorkflowState ComputeIdleStateTransition(bool exception) =>
            exception switch
            {
                true => Idle,
                false => Idle
            };

        public static VipaWorkflowState GetNextState(VipaWorkflowState state, bool exception) =>
            state switch
            {
                Undefined => ComputeUndefinedStateTransition(exception),
                CommandRequest => ComputeCommandRequestStateTransition(exception),
                CommandReply => ComputeCommandReplyStateTransition(exception),
                CommandComplete => ComputeCompleteStateTransition(exception),
                Idle => ComputeIdleStateTransition(exception),
                _ => throw new StateException($"Invalid state transition '{state}' requested.")
            };
    }
}
