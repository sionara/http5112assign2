using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112assign2.Controllers
{
    public class JThreeController : ApiController
    {
        /// <summary>
        /// Given the first and second term of a Sumac sequence, return its length.
        /// </summary>
        /// <param name="t1">first term of sequence</param>
        /// <param name="t2"> second term of sequence</param>
        /// <returns>
        /// length of the sumac sequence given first and second term.
        /// </returns>
        [HttpGet]
        [Route("api/JThree/SumacSeqLength/{t1}/{t2}")]
        public int SumacSeqLength(int t1, int t2)
        {
            int prevTerm = t1;
            int nextTerm = t2;
            int counter = 2; //sequence will always have at least two terms.

            while(prevTerm >= nextTerm)
            {
                t1 = nextTerm;
                t2 = prevTerm - nextTerm;
                prevTerm = t1;
                nextTerm = t2;
                counter++;
            }
            return counter; //represents length of sumac sequence
        }
    }
}
