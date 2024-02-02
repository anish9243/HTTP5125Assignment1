using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Performs Four mathematical Operations to Input
        /// </summary>
        /// <param name="id">The input number perform mathematical operations/param>
        /// <returns>The answer of the [(id * 2 + 3 - 1)/2 ] </returns>
        /// GET localhost:xx/api/NumberMachine/2 -> 3
        public int Get(int id)
        {
            int value = (id * 2 + 3 - 1) / 2;
            return value;
        }
    }
}
