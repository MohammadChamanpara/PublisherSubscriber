using PublishSubscribe.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Subscribers
{
    public class Subscriber1 : BaseSubscriber<string>
    {
        public override void Display(Message message)
        {
            Console.WriteLine($"{nameof(Subscriber1)} received {message.Content}.");
        }
    }
}
