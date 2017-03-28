using PublishSubscribe.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Subscribers
{
    public class Subscriber2 : BaseSubscriber<string>
    {
        public override void Display(Message message)
        {
            Console.WriteLine($"{nameof(Subscriber2)} received {message.Content}.");
        }
    }
}
