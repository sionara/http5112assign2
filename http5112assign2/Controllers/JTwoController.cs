using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112assign2.Controllers
{
    public class JTwoController : ApiController
    {
        /// <summary>
        /// Returns a message indicating if the balloon will touch the ground before the given max time or not.
        /// If it will touch the ground, it will also return the time it will take in hours.
        /// </summary>
        /// <param name="humidity"> Represents the humidity h, 0 ≤ h ≤ 100 </param>
        /// <param name="maxTime"> Represents the Max time M, 0 < M < 240 </param>
        /// <returns>
        /// GET: api/JTwo/balloonAltitude/30/10 -> The balloon first touches ground at hour: 6
        /// GET: api/JTwo/balloonAltitude/70/10 -> The balloon does not touch ground in the given time.
        /// </returns>
        [HttpGet]
        [Route("api/JTwo/balloonAltitude/{humidity}/{maxTime}")]
        public string balloonAltitude(int humidity, int maxTime)
        {
            for (int t = 1; t < maxTime; t++)
            {
                int A = -6*(t*t*t*t) + humidity*(t*t*t) + 2*(t*t) + t;
                if (A <= 0) {
                    return "The balloon first touches ground at hour: " + t;
                }
            }
            return "The balloon does not touch ground in the given time.";
        }
    }
}
