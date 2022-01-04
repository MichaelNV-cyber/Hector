namespace Hector
{
    internal class messageFactory
    {
        public Message createMessage(string action)
        {
            if (action == "actionType.request") { return new Request(); }

            else if (action == "actionType.response") { return new Response(); }

            return null;
        }
    }
}
