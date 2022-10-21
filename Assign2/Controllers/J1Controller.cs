using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary> 
        /// CCC 2006 The New CCC (Canadian Calorie Counting)
        /// prompt the user for a number for each type of food item then calculate and display the Calorie total. 
        /// </summary> 
        /// <returns>Returns the total calories output of the four inputs from the users </returns> 
        /// <example>http://localhost:51950/api/calcalc/2/3/1/4 
        ///431 + 118 + 100 + 0 = 649 calories 
        ///</example> 
        ///

        [Route("api/J1/menu/{Burger}/{sideOrder}/{drink}/{dessert}")]
        [HttpGet]
        public int menu(int burger, int sideOrder, int drink, int dessert)
        {

            int calories = 0;

            if (burger == 1)
            {
                calories += 461;
            }
            else if (burger == 2)
            {
                calories += 431;
            }
            else if (burger == 3)
            {
                calories += 420;
            }
            if (sideOrder == 1)
            {
                calories += 100;
            }
            else if (sideOrder == 2)
            {
                calories += 57;
            }
            else if (sideOrder == 3)
            {
                calories += 70;
            }

            if (drink == 1)
            {
                calories += 130;
            }
            else if (drink == 2)
            {
                calories += 160;
            }
            else if (drink == 3)
            {
                calories += 118;
            }

            if (dessert == 1)
            {
                calories += 167;
            }
            else if (dessert == 2)
            {
                calories += 266;
            }
            else if (dessert == 3)
            {
                calories += 75;
            }

            return calories;

        }
    }
}
