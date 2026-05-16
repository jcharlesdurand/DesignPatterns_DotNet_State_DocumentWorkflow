using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication.States
{
    public class ApprovedState : DocumentState
    {
        public ApprovedState(Document document) 
            : base(document) 
        {
        }

        public override void Submit()
        {
            Console.WriteLine("Already approved");
        }

        public override void Approve()
        {
            Console.WriteLine("Already approved");
        }

        public override void Reject(string reason)
        {
            Console.WriteLine("Cannot reject an approved document");
        }

        public override void Publish()
        {
            Console.WriteLine($"Document '{_document.Title}' published!");
            _document.PublishedAt = DateTime.Now;
            _document.SetState(new PublishedState(_document));
        }

        public override void Edit(string newContent)
        {
            Console.WriteLine("Cannot edit an approved document");
        }

        public override void Archive()
        {
            Console.WriteLine("Must publish before archiving");
        }

        public override string GetStateName() => "Approved";
    }
}
