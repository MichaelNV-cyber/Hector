namespace Hector
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* 
              to do:
                1.set Message class as abstract
                2.seperate files
                3.working with properties in C#
                4.add bin and obj files to .gitignore
                5.delete unecessary using commands 
            */

            string json = "{\"actionType\": \"actionType.response\",\"messageType\": \"messageType.startComm\", \"timeSent\": \"16:25\", \"isApproved\": \"True\"}";
            JSON_parser parser = new JSON_parser();
            parser.JSON_toClass(json);



        }
    }
}