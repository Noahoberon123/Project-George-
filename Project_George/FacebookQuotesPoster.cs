using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Project_George
{
    public static class FacebookQuotesPoster
    {
        [FunctionName("FacebookQuotesPoster")]
        public static void Run([TimerTrigger("0 */5 * * * *"
            #if DEBUG
            ,RunOnStartup = true
            #endif  
            )]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        } 

    }
}
