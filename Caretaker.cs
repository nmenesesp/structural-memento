using System;
using patterns.behavior.memento.interfaces;
using System.Collections.Generic;
using System.Linq;

namespace patterns.behavior.memento
{
    public class Caretaker

    {
        private List<IMemento> _history;
    
        // Gets or sets memento

        public List<IMemento> History
        {
            set { _history = value; }
            get { return _history; }
        }

        public Caretaker(){
            this.History = new List<IMemento>();
        }

        public void undo(){
            if (this._history.Count == 0)
            {
                return;
            }

            var memento = this._history.Last();
            this._history.Remove(memento);
            try
            {
                memento.restore();
            }
            catch (Exception)
            {
                this.undo();
            }
        }

        public void addMemento(IMemento memento){
            this.History.Add(memento);
        }
    }
}