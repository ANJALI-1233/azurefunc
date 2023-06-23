using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MyAzureFunction
{
    public static class MyFunction
    {
        [FunctionName("MyFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var crops = new List<object>
            {
                new { cropId = 0, cropName = "carrots" },
                new { cropId = 1, cropName = "potatoes" }
            };

            return new OkObjectResult(crops);
        }
    }
}
