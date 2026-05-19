using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public class PublishedState : DocumentState
    {
        public PublishedState(Document document)
         : base(document)
        {
        }

        public override void Archive()
        {
            Console.WriteLine($"Document '{_document.Title}' archived");
            _document.SetState(new ArchivedState(_document));
        }

        public override string GetStateName() => "Published";
    }
}
