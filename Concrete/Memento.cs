using System;
using patterns.behavior.memento.interfaces;

namespace patterns.behavior.memento.concrete
{
    public class Memento: IMemento {

        private Originator originator;
        private string _state;
    
        // Constructor
        public Memento(string state, Originator originator)
        {
            this._state = state;
            this.originator = originator;
        }
    
        // Gets or sets state
        public string State
        {
            get { return _state; }
        }

        // Restores original state
        public void restore()
        {
            Console.WriteLine("Restoring state to: " + this.State);
            originator.State = this.State;
        }
    }
}