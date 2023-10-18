using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Caching;
using System.Web.Http;

namespace http5112assign2.Controllers
{
    public class JOneController : ApiController
    {
        /// <summary>
        /// Outputs which alien species user saw based on input.
        /// </summary>
        /// <param name="Ant"> Number of Antennas </param>
        /// <param name="Eyes"> Number of Eyes </param>
        /// <returns>
        /// GET: api/JOne/whichAlien/4/5 -> VladSaturnian
        /// GET: api/JOne/whichAlien/2/3 -> "VladSaturnian, GraemeMercurian"
        /// </returns>
        /// 
        [HttpGet]
        [Route("api/JOne/whichAlien/{Ant}/{Eyes}")]
        public List<string> whichAlien(int Ant, int Eyes)
        {
            string tm = "TroyMartian";
            string vs = "VladSaturnian";
            string gm = "GraemeMercurian";

            List<string> output = new List<string>();

            if (Ant > 6) // can only be tm if eyes condition is also satisfied
            {
                if (Eyes <= 4) { output.Add(tm); } // check eye condition
            }
            

            else if (Ant <= 6) // can be any of them
                {
                    if (Eyes > 4) { output.Add(vs); } // must be vs
                    else if (Eyes == 4) { output.Add(tm + ", " + vs); } // must be vs or tm
                    else if ((Eyes <= 3) && (Ant <= 2)) { output.Add(gm); } // must be gm
                    else if (Eyes == 2 || Eyes == 3) { output.Add(tm + ", " + vs + ", " + gm); } // must be all of them
                    else if ((Eyes < 2) && (Ant >= 3 && Ant < 7)) { output.Add(tm); } // must be tm
                    else { output.Add(tm + ", " + gm); } // must be tm or vs
                }

            return output;
        }
    }
}
