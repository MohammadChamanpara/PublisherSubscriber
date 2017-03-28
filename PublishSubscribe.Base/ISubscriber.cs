using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Base
{
    public interface ISubscriber
    {
        void Display(Message message);
        void Subscribe(IPublisher publisher);
    }
}
