using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.Base
{
    public class Message
    {
        public string Content { get; set; }
        public virtual bool Transformed { get; set; }
    }
}
