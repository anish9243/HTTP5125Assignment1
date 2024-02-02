using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// Greeting Hello World
        /// </summary>
        /// <param name="id">Greeting to Hello world</param>
        /// <returns>Hello World</returns>
        /// GET localhost:xx/api/Greeting -> Helllo World
        public string Get()
        {
            return "Hello World";
        }
        /// <summary>
        /// Greeting Hello World / Generate a greeting string to the provided id 
        /// </summary>
        /// <param name="id">The given id is used for how many people are there for Greeting.</param>
        /// <returns>Greeting to {id} People!</returns>
        /// GET localhost:xx/api/Greeting/id -> Greeting to {id} People!
        public string Get(int id)
        {
            return "Greeting to " + id + " People!";
        }
    }
}
