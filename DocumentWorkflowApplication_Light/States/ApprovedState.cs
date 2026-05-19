using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public class ApprovedState : DocumentState
    {
        public ApprovedState(Document document)
         : base(document)
        {
        }

        public override string GetStateName() => "Approved";

        public override void Publish()
        {
            Console.WriteLine($"Document '{_document.Title}' published!");
            _document.PublishedAt = DateTime.Now;
            _document.SetState(new PublishedState(_document));
        }
    }
}
