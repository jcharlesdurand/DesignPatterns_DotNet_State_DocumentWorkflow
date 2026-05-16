using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication.States
{
    public class PublishedState : DocumentState
    {
        public PublishedState(Document document)
            : base(document) 
        {
        }

        public override void Submit()
        {
            Console.WriteLine("Already published");
        }

        public override void Approve()
        {
            Console.WriteLine("Already published");
        }

        public override void Reject(string reason)
        {
            Console.WriteLine("Cannot reject a published document");
        }

        public override void Publish()
        {
            Console.WriteLine("Already published");
        }

        public override void Edit(string newContent)
        {
            Console.WriteLine("Cannot edit a published document (read-only)");
        }

        public override void Archive()
        {
            Console.WriteLine($"Document '{_document.Title}' archived");
            _document.SetState(new ArchivedState(_document));
        }

        public override string GetStateName() => "Published";
    }
}
