using PublishSubscribe.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    public class Publisher : IPublisher
    {
        public DateTime LastPublishTime { get; protected set; }

        public event EventHandler<Message> MessagePublished;
        protected void OnMessagePublished(Message message)
        {
            this.MessagePublished?.Invoke(this, message);
            LastPublishTime = DateTime.Now;
        }
        public virtual void TransformMessage(Message message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            message.Transformed = true;
        }
        public virtual void Publish(Message message)
        {
            TransformMessage(message);
            OnMessagePublished(message);
        }
    }
}
