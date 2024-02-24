using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Verifone.VIPA.Processing;
using Verifone.VIPA.Interfaces;
using XO.Requests;

namespace Verifone.VIPA
{
    internal class VipaStateMachine : IVipaStateMachine
    {
        ProcessingResult processingResult;

        public async ValueTask<ProcessingResult> ProcessCommandRequest(Requests request, CancellationTokenSource token)
        {
            processingResult = ProcessingResult.None;
            RequestProcessing.ProcessRequest(RequestResponse, token);
            await RequestResponseFromRequest();
            return processingResult;
        }

        private async ValueTask<ProcessingResult> RequestResponseFromRequest()
        {
            while(processingResult == ProcessingResult.None)
            {
                await Task.Delay(10);
            }

            return processingResult;
        }

        public void RequestResponse(ProcessingResult result)
        {
            Debug.WriteLine($"device: request response=[{result}]");
            processingResult = result;

            switch (result)
            {
                case ProcessingResult.Sucess:
                {
                    break;
                }

                case ProcessingResult.Fail:
                {
                    break;
                }

                case ProcessingResult.Cancel:
                {
                    break;
                }
            }
        }
    }
}
