using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)

        {
            ///<summary>
            ///Calculates the no. of fortnight and gives the total according to input.
            ///<param name="id">User input number of days </param>
            ///<param name="OneFN">14 days, or a fortnight</param>
            ///<param name="FNCount">fortnight divided by user input +1 to push into next billing cycle</param>
            ///<param name="FNCost">cost per fortnight</param>
            ///<param name="HST">HST percentage</param>
            ///<param name="Total">total </param> 
            ///</summary>
            ///<return>The fortnight and the hst and the total </return>
            ///GET http://localhost:xx/api/HostingCost/1 --> 1 fortnights at $5.5/FN = $5.5CAD HST 13% = $0.715CAD Total = $6.215CAD
            /// FN stands for Fortnight
            
            int OneFN = 14;
            int FNCount = (id / OneFN) + 1;
            float FNCost = 5.50f;
            float HST = 0.13f;
            float Total = (FNCount * FNCost) * (HST + 1);
            return FNCount + " fortnights at $" + FNCost + "/FN = $" + (FNCount * FNCost) + "CAD HST 13% = $" + (FNCount * FNCost * HST) + "CAD Total = $" + Total + "CAD";

        }
    }
}
