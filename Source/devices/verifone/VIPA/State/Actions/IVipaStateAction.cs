using System;
using System.Threading.Tasks;

namespace Verifone.VIPA.State.Actions
{
    internal interface IVipaStateAction : IDisposable
    {
        StateException LastException { get; }
        //IVipaStateController Controller { get; }
        VipaWorkflowState WorkflowStateType { get; }
        void SetState(object stateObject);
        //VipaWorkflowStopReason StopReason { get; }
        bool DoDeviceDiscovery();
        Task DoWork();
    }
}
