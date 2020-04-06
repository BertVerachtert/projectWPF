using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mobiliteit_Bert_Verachtert_r0710075.Messages
{
    class UpdateFinishedMessage
    {
       public enum MessageType {Updated,Deleted,Inserted};
        public UpdateFinishedMessage(MessageType Actie)
        {
            Type = Actie;
        }

        public  MessageType Type { get; set; }
    }
}
