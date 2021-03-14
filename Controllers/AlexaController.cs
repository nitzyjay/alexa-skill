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
                        text = "Thank you for opening my app, Have a nice day!"
                    },
                    card = new
                    {
                        type = "Standard",
                        title = "Nitish",
                        content = "Have a nice day!",
                        image = new {
                           smallImageUrl = "http://nitishjain.com/images/avatar.jpg",
                           largeImageUrl = "http://nitishjain.com/images/avatar.jpg"
                        }
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
