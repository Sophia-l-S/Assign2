using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary> 
        ///CCC 2018 J3: Are we there yet? 
        /// calculate a distance table that indicates the distance between any two of the cities 
        /// </summary> 
        /// <returns> 5 lines, with the ith line (1 ≤ i ≤ 5) containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.</returns> 
        /// <example>http://localhost:51950/api/citydis/3/10/12/5 
        ///0 3 13 25 30 
        ///3 0 10 22 27 
        ///13 10 0 12 17 
        ///25 22 12 0 5 
        ///30 27 17 5 0 
        ///</example> 


        /// [Route("api/J3/citydis/{a}/{b}/{c}/{d}")]
        /// [HttpGet]
        ///public int citydis(int a, int b, int c, int d)
        ///{
        ///int a, b, c, d; 
        ///
        ///int first=a, second=a+b, third=a+b+c, fourth=a+b+c+d; 
        ///
        ///return a,a+b,a+b+c,a+b+c+d
        ///return a,b,b+c,b+c+d
        ///return a+b,b,c,c+d
        ///return a+b+c,b+c,c,d
        ///a+b+c+d,b+c+d,c+d,d
        ///
        ///}



    }
}
