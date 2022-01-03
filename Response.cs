namespace Hector
{
    internal class Response :Message
    {
        bool isApproved;

        public Response(actionType actionType, messageType messageType, string timeSent, bool isApproved) : base(actionType, messageType, timeSent)
        {
            this.isApproved = isApproved;
        }
    }
}
