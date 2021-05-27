using System;
using patterns.behavior.memento.concrete;

namespace patterns.behavior.memento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Originator o = new Originator();
            o.State = "On";
        
            Caretaker c = new Caretaker();
            c.addMemento(o.save());

            // Continue changing originator
            o.State = "Off";      

            // Restore saved state
            c.undo();*/

            ////RUTA
            Route route = new Route(1, 0.7456,-74.523);
            Caretaker c = new Caretaker();
            c.addMemento(route.save());
            route.move(new Random().NextDouble(),new Random().NextDouble());
            c.addMemento(route.save());
            route.move(new Random().NextDouble(),new Random().NextDouble());
            c.addMemento(route.save());
            route.move(new Random().NextDouble(),new Random().NextDouble());
            c.undo();
            c.undo();

            // Wait for user
            Console.ReadKey();
        }
    }
}
