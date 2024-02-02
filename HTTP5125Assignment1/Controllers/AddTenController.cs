using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        ///<summary>
        ///Add 10 into input
        ///</summary>
        ///<param name = "id" > The input number to add from</param>
        ///<returns>The input number plus 10.</returns>
        /// GET Localhost:xx/api/AddTen/10 → 20

        public int Get(int id)
        {
            int value = id + 10;
            return value;
        }
    }
}
