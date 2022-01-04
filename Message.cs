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

    internal abstract class Message
    {
        actionType actionType { get; set; }
        messageType messageType { get; set; }
        string timeSent { get; set; }

    }
}
