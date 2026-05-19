using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public class RejectedState : DocumentState
    {
        public RejectedState(Document document)
         : base(document)
        {
        }

        public override void Edit(string newContent)
        {
            _document.Content = newContent;
            _document.RejectionReason = null;
            Console.WriteLine($"Document edited and back to draft");
            _document.SetState(new DraftState(_document));
        }

        public override string GetStateName() => "Rejected";
    }
}
