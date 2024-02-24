using System;
using System.Threading;
using System.Threading.Tasks;

namespace Verifone.VIPA.Processing
{
    static public class RequestProcessing
    {
        public static async void ProcessRequest(Action<ProcessingResult> callback, CancellationTokenSource token)
        {
            try
            {
                await Task.Run(async delegate
                {
                    await Task.Delay(new TimeSpan(0, 0, 3), token.Token);
                });
            }
            catch (OperationCanceledException)
            {
                callback(ProcessingResult.Cancel);
                return;
            }

            ProcessingResult result = new Random().Next(0, 2) == 0 ? ProcessingResult.Sucess : ProcessingResult.Fail;
            callback(result);
        }
    }
}
