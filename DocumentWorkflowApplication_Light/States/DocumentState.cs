using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public abstract class DocumentState
    {
        protected Document _document;

        public DocumentState(Document document)
        {
            _document = document;
        }
        public abstract string GetStateName();

        public virtual void Submit()
        {
            Console.WriteLine($"Submit() not implemented in state {GetStateName()}");
        }

        public virtual void Approve()
        {
            Console.WriteLine($"Approve() not implemented in state {GetStateName()}");
        }

        public virtual void Reject(string reason)
        {
            Console.WriteLine($"Reject() not implemented in state {GetStateName()}");
        }

        public virtual void Publish()
        {
            Console.WriteLine($"Publish() not implemented in state {GetStateName()}");
        }

        public virtual void Edit(string newContent)
        {
            Console.WriteLine($"Edit() not implemented in state {GetStateName()}");
        }

        public virtual void Archive()
        {
            Console.WriteLine($"Archive() not implemented in state {GetStateName()}");
        }
    }
}
