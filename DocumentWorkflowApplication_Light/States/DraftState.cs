using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public class DraftState : DocumentState
    {
        public DraftState(Document document)
            : base(document)
        {
        }

        public override string GetStateName() => "Draft";

        public override void Submit()
        {
            Console.WriteLine($"Document '{_document.Title}' submitted for review");
            _document.SetState(new InReviewState(_document));
        }

        public override void Edit(string newContent)
        {
            _document.Content = newContent;
            Console.WriteLine($"Document edited: '{newContent[..Math.Min(30, newContent.Length)]}...'");
        }
    }
}
