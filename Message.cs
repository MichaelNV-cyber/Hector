namespace Hector
{
    public enum actionType
    {
        request,
        response,
        unspecified
    }

    public enum messageType
    {
        startComm,
        endComm,
        classification,
        unspecified
    }

    internal class Message
    {
        actionType actionType;
        messageType messageType;
        string timeSent;
        public Message(actionType actionType, messageType messageType, string timeSent)
        {
            this.actionType = actionType;
            this.messageType = messageType;
            this.timeSent = timeSent;
        }
    }
}
