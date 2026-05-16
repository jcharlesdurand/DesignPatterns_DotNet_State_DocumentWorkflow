using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication.States
{
    public class RejectedState : DocumentState
    {
        public RejectedState(Document document) 
            : base(document) 
        {
        }

        public override void Submit()
        {
            Console.WriteLine("Cannot resubmit rejected document directly. Edit first.");
        }

        public override void Approve()
        {
            Console.WriteLine("Cannot approve a rejected document");
        }

        public override void Reject(string reason)
        {
            Console.WriteLine("Already rejected");
        }

        public override void Publish()
        {
            Console.WriteLine("Cannot publish a rejected document");
        }

        public override void Edit(string newContent)
        {
            _document.Content = newContent;
            _document.RejectionReason = null;
            Console.WriteLine($"Document edited and back to draft");
            _document.SetState(new DraftState(_document));
        }

        public override void Archive()
        {
            Console.WriteLine("Cannot archive a rejected document");
        }

        public override string GetStateName() => "Rejected";
    }
}
