using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary> 
        /// CCC 2007 I Speak TXTMSG
        /// Write a program that will continually input a short form and output the translation for an adult using
        /// the list of text abbreviations.
        ///  Users may enter text that is found in the translation table, or they may enter other words.
        /// </summary> 
        /// <returns>Returns the output of the corrisponding abbreviations that the user input</returns> 
        /// <example>http://localhost:51950/api/J2/text/CU 
        ///see you
        ///http://localhost:51950/api/J2/text/TTYL
        ///talk to you later
        ///</example> 

        [Route("api/J2/text/{message}")]
        [HttpGet]
        public string text(string message)
        {

            while(true) {

                if (message == "CU")
                {
                    return "see you";
                }
                else if (message == ":-)")
                {
                    return "I'm happy";
                }
                else if (message == ":-(")
                {
                    return "I'm unhappy";
                }
                else if (message == ";-)")
                {
                    return "wink";
                }
                else if (message == ":-P")
                {
                    return "stick out my tongue";
                }
                else if (message == "(~.~)")
                {
                    return "sleepy";
                }
                else if (message == "TA")
                {
                    return "totally awesome";
                }
                else if (message == "CCC")
                {
                    return "Canadian Computing Competition";
                }
                else if (message == "CUZ")
                {
                    return "because";
                }
                else if (message == "TY")
                {
                    return "thank-you";
                }
                else if (message == "YW")
                {
                    return "you're welcome";
                }
                else if (message == "TTYL")
                {
                    return "talk to you later";
                }
                else
                {
                    return message;
                }


            }
        }



        }
}
