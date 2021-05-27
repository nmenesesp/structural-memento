using System;
using patterns.behavior.memento.interfaces;

namespace patterns.behavior.memento.concrete
{
  public class Originator : IOriginator  {
    private string _state; 
    public string State {
      get { return _state; }
      set
      {
        _state = value;
        Console.WriteLine("State = " + _state);
      }
    }

    // Creates memento 
    public IMemento save()
    {
      return (new Memento(_state, this));
    }
  }
}