namespace Verifone.VIPA.State
{
    public enum VipaWorkflowState
    {
        /// <summary>
        /// Default state for all SubWorkflows.
        /// </summary>
        Undefined,

        CommandRequest,

        CommandReply,

        CommandComplete,

        Idle
    }
}
