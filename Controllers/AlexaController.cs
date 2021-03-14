using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Eureka.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    //public class AlexaController : ControllerBase
    public class AlexaController
    {            
        [HttpPost, Route("api/alexa/demo")]
        public dynamic Nitish(dynamic request)
        {
            return new
            {
                version = "1.0",
                sessionAttributes = new { },
                response = new
                {
                    outputSpeech = new
                    {
                        type = "PlainText",
                        text = "Hello from Nitish"
                    },
                    card = new
                    {
                        type = "Simple",
                        title = "Nitish",
                        content = "Hello from Nitish, today is a fine day!"
                    },
                    shouldEndSession = true
                }
            };
        }

        [HttpGet, Route("api/alexa/demo")]
        public dynamic Get()
        {
            var rng = new Random();
            return "The API is up and running";
        }
    }
}
