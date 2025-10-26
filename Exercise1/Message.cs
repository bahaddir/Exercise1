using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1.Validations;

namespace Exercise1
{
    public class Message
    {
		private Guid _id;
		private string _senderUsername;
		private string _receiverUsername;
		private string _content;


        public Message(string content, string receiverUsername, string senderUsername)
        {
            if (receiverUsername == senderUsername)
                throw new ArgumentException("receiver username and sender username must be different");

            Guid _id = Guid.NewGuid();
            Content = content;
            ReceiverUsername = receiverUsername;
            SenderUsername = senderUsername;
            CreatedAt= DateTime.Now;
        }

        
        public Guid Id
        { 
            get { return _id; }
		}
        public string Content
        {
            get { return _content; }
            private set 
            {

                _content = CheckValidation.CheckLength(value, 3);
            }
        }

        public string ReceiverUsername
        {
            get { return _receiverUsername; }
            private set { _receiverUsername = value; }
        }

        public string SenderUsername
        {
            get { return _senderUsername; }
            private set { _senderUsername = value; }
        }
        public DateTime CreatedAt{get;}

        public override string ToString()
        {
            return $"Receiver: {_receiverUsername}\n\nMessage:\n{_content}\n\nSent By:{_senderUsername}\nSent at: {CreatedAt}";
        }

    }
}
