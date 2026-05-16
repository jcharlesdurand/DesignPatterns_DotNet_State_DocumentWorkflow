using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication.States
{
    public class ArchivedState : DocumentState
    {
        public ArchivedState(Document document) 
            : base(document) 
        {
        }

        public override void Submit() 
        {
            Console.WriteLine("Document is archived (read-only)");
        }

        public override void Approve() 
        {
            Console.WriteLine("Document is archived (read-only)");
        }

        public override void Reject(string reason)
        {
            Console.WriteLine("Document is archived (read-only)"); 
        }

        public override void Publish()
        { 
            Console.WriteLine("Document is archived (read-only)"); 
        }

        public override void Edit(string newContent) 
        { 
            Console.WriteLine("Document is archived (read-only)"); 
        }

        public override void Archive() 
        { 
            Console.WriteLine("Already archived"); 
        }

        public override string GetStateName() => "Archived";
    }
}
