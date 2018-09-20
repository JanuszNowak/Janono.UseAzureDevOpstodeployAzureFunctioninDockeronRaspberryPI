
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1
{
    public static class IsAlive
    {
        [FunctionName("IsAlive")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            //var a=typeof(RuntimeEnvironment).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            return (ActionResult)new OkObjectResult(new { Timestamp = DateTime.Now, Region = Environment.GetEnvironmentVariable("REGION_NAME") });
        }


    }
}
