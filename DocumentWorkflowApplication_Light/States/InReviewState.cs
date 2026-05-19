using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public class InReviewState : DocumentState
    {
        public InReviewState(Document document)
         : base(document)
        {
        }

        public override string GetStateName() => "InReview";

        public override void Approve()
        {
            Console.WriteLine($"Document '{_document.Title}' approved");
            _document.SetState(new ApprovedState(_document));
        }

        public override void Reject(string reason)
        {
            Console.WriteLine($"Document rejected. Reason: {reason}");
            _document.RejectionReason = reason;
            _document.SetState(new RejectedState(_document));
        }
    }
}
