using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light.States
{
    public class ArchivedState : DocumentState
    {
        public ArchivedState(Document document)
         : base(document)
        {
        }

        public override string GetStateName() => "Archived";
    }
}
