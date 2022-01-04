namespace Hector
{
    internal abstract class Message :types
    {
        actionType actionType { get; set; }
        messageType messageType { get; set; }
        string timeSent { get; set; }

    }
}
