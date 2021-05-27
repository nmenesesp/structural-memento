using System;
using patterns.behavior.memento.interfaces;

namespace patterns.behavior.memento.concrete
{
    public class Step : IMemento {
        private int _id;
        public int Id{
         get { return this._id;} 
        }

        private double _latitude;
        private double _longitude;
        
        public double Latitud {
            get { return this._latitude;}
        }

        public double Longitud {
            get { return this._longitude;}
        }

        private Route originator;

        public Step (int id, double latitud, double longitud, Route originator){
            this._id = id;
            this._latitude = latitud;
            this._longitude = longitud;
            this.originator = originator;
        }

        // Restores original state
        public void restore()
        {
            Console.WriteLine("Restoring route : " + this.Id);
            originator.move(this.Latitud, this.Longitud);
        }
    }
}