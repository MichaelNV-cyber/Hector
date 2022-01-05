using Newtonsoft.Json.Linq;


namespace Hector
{
    internal class JSON_parser
    {
        public void JSON_toClass(string jsonIn)
        {
            messageFactory messageFactory = new messageFactory();
            JObject toParse = JObject.Parse(jsonIn);

            string type = (string)toParse["actionType"];
            Message msg = messageFactory.createMessage(type);

            Newtonsoft.Json.JsonConvert.PopulateObject(jsonIn, msg);

        }
    }
}
