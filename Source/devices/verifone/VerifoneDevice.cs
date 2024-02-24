using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Verifone.VIPA;
using Verifone.VIPA.Interfaces;
using Verifone.VIPA.Processing;
using XO.Requests;

namespace Verifone
{
    public class VerifoneDevice
    {
        private IVipaStateMachine vipaStateMachine = new VipaStateMachine();

        public async ValueTask<ProcessingResult> ProcessRequest(Requests request)
        {
            Debug.WriteLine($"device: process request: '{request}'");

            CancellationTokenSource token = new CancellationTokenSource();

            ProcessingResult processingResult;
            processingResult = await vipaStateMachine.ProcessCommandRequest(request, token);
            return processingResult;
        }
    }
}
