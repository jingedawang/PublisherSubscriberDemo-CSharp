using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberDemo
{
    class Publisher
    {
        public delegate void Message(string message);
        public Message SomeMessage;

        public void Start()
        {
            while (true)
            {
                SomeMessage("Some message from publisher.");
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
