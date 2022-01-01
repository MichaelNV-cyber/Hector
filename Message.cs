using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFproject
{
    public enum actionType
    {
       request,
       response
    }

    public enum messageType
    {
        startComm,
        endComm,
        classification
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
