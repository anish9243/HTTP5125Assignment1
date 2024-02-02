using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Square the input
        /// </summary>
        /// <param name="id">The input number to square from</param>
        /// <returns>The square of the input number.</returns>
        /// GET localhost:xx/api/Square/2 -> 4
        public int Get(int id)
        {
            int value = id * id;
            return value;
        }
    }
}
