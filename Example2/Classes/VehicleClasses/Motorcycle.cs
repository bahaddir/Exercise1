using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.AbstractClasses;

namespace Example2.Classes.VehicleClasses
{
    public class Motorcycle : BaseVehicle
    {

        private int _engineCC;
        private bool _requireHelmet;
        public Motorcycle(string brand, string model, int modelYear, decimal baseRentalPrice,int engineCC,bool requireHelmet) : base(brand, model, modelYear, baseRentalPrice)
        {
            EngineCC = engineCC;
            RequireHelmet = requireHelmet;
        }


        public bool RequireHelmet
        {
            get { return _requireHelmet; }
            private set { _requireHelmet = value; }
        }

        public int EngineCC
        {
            get { return _engineCC; }
            private set { _engineCC = value; }
        }

    }
}
