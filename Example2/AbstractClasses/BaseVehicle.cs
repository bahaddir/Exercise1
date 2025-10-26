using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.Interfaces;

namespace Example2.AbstractClasses
{
    public abstract class BaseVehicle : IEntity, IRentable
    {
        private string _brand;
        private string _model;
        private int _modelYear;
        private decimal _baseRentalPrice;

        protected BaseVehicle(string brand, string model, int modelYear, decimal baseRentalPrice )
        {
            Guid= Guid.NewGuid();
            BaseRentalPrice = baseRentalPrice;
            ModelYear = modelYear;
            Model = model;
            Brand = brand;
        }

        public decimal BaseRentalPrice
        {
            get { return _baseRentalPrice; }
            protected set { _baseRentalPrice = value; }
        }



        public int ModelYear
        {
            get { return _modelYear; }
            protected set { _modelYear = value; }
        }

        public string Model
        {
            get { return _model; }
            protected set { _model = value; }
        }

        public string Brand
        {
            get { return _brand; }
            protected set { _brand = value; }
        }

        public Guid Guid { get; private set; }

        

        public bool IsAvailable(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"brand:{_brand}\nmodel:{_model},\nmodel year{_modelYear}\nbaserentalprice:{_baseRentalPrice}";
        }
    }
}
