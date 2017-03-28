using PublishSubscribe.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Subscribers
{
    public abstract class BaseSubscriber<T> : ISubscriber
    {
        public abstract void Display(Message message);

        public virtual void Subscribe(IPublisher publisher)
        {
            publisher.MessagePublished += Publisher_MessagePublished;
        }
        public virtual void Unsubscribe(IPublisher publisher)
        {
            publisher.MessagePublished -= Publisher_MessagePublished;
        }
        protected virtual void Publisher_MessagePublished(object sender, Message e)
        {
            this.Display(e);
        }
    }
}
