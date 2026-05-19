using DocumentWorkflowApplication_Light.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkflowApplication_Light
{
    public class Document
    {
        private DocumentState _state;

        public string Title { get; set; }
        public string Content { get; set; }
        public string? RejectionReason { get; set; }
        public DateTime? PublishedAt { get; set; }

        public Document(string title, string content)
        {
            Title = title;
            Content = content;
            _state = new DraftState(this);
        }

        public void SetState(DocumentState newState)
        {
            Console.WriteLine($"  => State: {_state.GetStateName()} => {newState.GetStateName()}");
            _state = newState;
        }

        public string CurrentState => _state.GetStateName();

        public void Submit() { _state.Submit(); }
        public void Approve() { _state.Approve(); }
        public void Reject(string reason) { _state.Reject(reason); }
        public void Publish() { _state.Publish(); }
        public void Edit(string newContent) { _state.Edit(newContent); }
        public void Archive() { _state.Archive(); }
    }
}
