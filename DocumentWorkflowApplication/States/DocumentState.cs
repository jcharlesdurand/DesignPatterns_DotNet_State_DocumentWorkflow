using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication.States
{
    public abstract class DocumentState
    {
        protected Document _document;

        public DocumentState(Document document)
        {
            _document = document;
        }

        public abstract void Submit();
        public abstract void Approve();
        public abstract void Reject(string reason);
        public abstract void Publish();
        public abstract void Edit(string newContent);
        public abstract void Archive();
        public abstract string GetStateName();
    }
}
