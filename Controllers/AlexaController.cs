using System;
using Microsoft.AspNetCore.Mvc;

namespace Eureka.Controllers
{
    public class AlexaController
    {
        //public AlexaController()
        //{
        //}
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
                        content = "Hello from Nitish"
                    },
                    shouldEndSession = true
                }
            };
        }
    }
}
