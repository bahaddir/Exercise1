using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.AbstractClasses;

namespace Example2.Classes.VehicleClasses
{
    public class Truck : BaseVehicle
    {
        public Truck(string brand, string model, int modelYear, decimal baseRentalPrice,int loadCapacity,bool heavyDuty) : base(brand, model, modelYear, baseRentalPrice)
        {
            LoadCapacity= loadCapacity;
            HeavyDuty= heavyDuty;
        }

        private int _loadCapacity;
        private bool _isHeavyDuty;

        public bool HeavyDuty
        {
            get { return _isHeavyDuty; }
            private set { _isHeavyDuty = value; }
        }

        public int LoadCapacity
        {
            get { return _loadCapacity; }
            private set { _loadCapacity = value; }
        }


    }
}
