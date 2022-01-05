namespace Hector
{
    internal abstract class types
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
    }
}
