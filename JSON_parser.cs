using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json.Linq;



namespace Hector
{
    internal class JSON_parser
    {
        public void JSON_toClass(string jsonIn)
        {
            JObject toParse = JObject.Parse(jsonIn); 
            
            string type = (string)toParse["actionType"];

            

            Newtonsoft.Json.JsonConvert.PopulateObject(jsonIn, msg);
    

        }
    }
} //VAR MSG = JSON.CONVERT(JSONSTRING

