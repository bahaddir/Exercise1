using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.AbstractClasses;
namespace Example2.Classes.VehicleClasses
{
    public class Car : BaseVehicle
    {
        private int _numberOfSeats;
        private bool _hasAirConditioning;


        public Car(string brand, string model, int modelYear, decimal baseRentalPrice, int numberOfSeats, bool hasAirConditioning) : base(brand, model, modelYear, baseRentalPrice)
        {
            HasAirConditioning = hasAirConditioning;
            NumberOfSeats = numberOfSeats;
        }

        

        

        public bool HasAirConditioning
        {
            get { return _hasAirConditioning; }
            private set { _hasAirConditioning = value; }
        }

        public int NumberOfSeats
        {
            get { return _numberOfSeats; }
            private set { _numberOfSeats = value; }
        }




    }
}
