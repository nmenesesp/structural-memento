using System;
using patterns.behavior.memento.interfaces;

namespace patterns.behavior.memento.concrete
{
    public class Route : IOriginator {
        private int _id;
        public int Id{
         get { return this._id;}   
         set { this._id = value;}
        }

        private double _latitude;
        private double _longitude;
        
        public double Latitud {
            get { return this._latitude;}
            set { this._latitude = value;}
        }

        public double Longitud {
            get { return this._longitude;}
            set { this._longitude = value;}
        }

        public Route (int id, double latitud, double longitud){
            this.Id = id;
            this.Latitud = latitud;
            this.Longitud = longitud;
        }

        // Creates memento 
        public IMemento save()
        {
            return (new Step(this.Id, this.Latitud, this.Longitud, this));
        }

        public void move(double latitud, double longitud) {
            this.Latitud = latitud;
            this.Longitud = longitud;

            Console.WriteLine ("Posición actual => Latitud : " + this.Latitud + "  , Longitud : " + this.Longitud);
            
        }
        

    }
}