using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication.States
{
    public class DraftState : DocumentState
    {
        public DraftState(Document document) 
            : base(document) 
        {
        }

        public override void Submit()
        {
            Console.WriteLine($"Document '{_document.Title}' submitted for review");
            _document.SetState(new InReviewState(_document));
        }

        public override void Approve()
        {
            Console.WriteLine("Cannot approve: document is in draft");
        }

        public override void Reject(string reason)
        {
            Console.WriteLine("Cannot reject: document is in draft");
        }

        public override void Publish()
        {
            Console.WriteLine("annot publish: document must be approved first");
        }

        public override void Edit(string newContent)
        {
            _document.Content = newContent;
            Console.WriteLine($"Document edited: '{newContent[..Math.Min(30, newContent.Length)]}...'");
        }

        public override void Archive()
        {
            Console.WriteLine("Cannot archive a draft");
        }

        public override string GetStateName() => "Draft";
    }
}
