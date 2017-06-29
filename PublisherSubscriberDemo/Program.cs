using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.SomeMessage += message => { Console.WriteLine("Subscriber 1: " + message); };
            publisher.SomeMessage += message => { Console.WriteLine("Subscriber 2: " + message); };
            publisher.Start();
        }
    }
}
