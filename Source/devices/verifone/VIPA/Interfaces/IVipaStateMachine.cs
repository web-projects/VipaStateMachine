using System.Threading;
using System.Threading.Tasks;
using Verifone.VIPA.Processing;
using XO.Requests;

namespace Verifone.VIPA.Interfaces
{
    public interface IVipaStateMachine
    {
        ValueTask<ProcessingResult> ProcessCommandRequest(Requests request, CancellationTokenSource token);
        void RequestResponse(ProcessingResult result);
    }
}
