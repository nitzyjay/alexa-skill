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
        public dynamic MyApp(dynamic request)
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
                        text = "Thank you for opening my test app, Have a nice day!"
                    },
                    card = new
                    {
                        type = "Standard",
                        title = "Nitish's App",
                        content = "Have a nice day!",
                        image = new {
                           smallImageUrl = "https://media-exp1.licdn.com/dms/image/C4D03AQF-Yt1AroC0SQ/profile-displayphoto-shrink_200_200/0/1609624402960?e=1621468800&v=beta&t=uEakq5UOYp8m_iHtoaE90XMtDDNmXw0Kpx1I9SjDMwQ",
                           largeImageUrl = "https://media-exp1.licdn.com/dms/image/C4D03AQF-Yt1AroC0SQ/profile-displayphoto-shrink_200_200/0/1609624402960?e=1621468800&v=beta&t=uEakq5UOYp8m_iHtoaE90XMtDDNmXw0Kpx1I9SjDMwQ"
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
