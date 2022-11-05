using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMessanger
{
    public class Message
    {
        public Message(string userName, string messageText, DateTime timeStemp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStemp = timeStemp;
        }

        public Message()
        {
            UserName = "System";
            MessageText = "Server is running...";
            TimeStemp = DateTime.Now;
        }


        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStemp{ get; set; }

        public override string? ToString()
        {
            string output = String.Format("{0} <{2}>: {1}", UserName, MessageText, TimeStemp);
            return output;
        }
    }
}
