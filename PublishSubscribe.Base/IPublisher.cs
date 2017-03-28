using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Base
{
    public interface IPublisher
    {
        event EventHandler<Message> MessagePublished;

        void TransformMessage(Message message);

        void Publish(Message message);
    }
}
