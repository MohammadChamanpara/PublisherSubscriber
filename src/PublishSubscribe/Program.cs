using PublishSubscribe.Base;
using PublishSubscribe.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            IPublisher publisher = LoadPublisher();
            List<ISubscriber> subscribers = LoadSubscribers();

            foreach (var subscriber in subscribers)
                subscriber.Subscribe(publisher);

            Console.Write("Enter a message to publish to subscribers: ");
            var message = new Message() { Content = Console.ReadLine(), Transformed = false };
            Console.WriteLine();
            publisher.Publish(message);
            Console.WriteLine();
        }

        private static IPublisher LoadPublisher()
        {
            /* Extension point to load publisher or publishers from dll files or a service, etc.*/
            return new Publisher();
        }

        private static List<ISubscriber> LoadSubscribers()
        {
            /* Extension point to load subscribers from dll files or a service, etc.*/
            return new List<ISubscriber>()
            {
                new Subscriber1(),
                new Subscriber2()
            };
        }
    }
}
