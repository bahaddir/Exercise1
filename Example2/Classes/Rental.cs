using Example2.AbstractClasses;
using Example2.Interfaces;
using Example2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Example2.Classes
{
    public class Rental : IEntity
    {

        private Guid _vehicleGuid;
        private Guid _customerGuid;
        private DateTime _startDate;
        private DateTime _endDate;
        private BaseVehicle _vehicle;

        public Rental(BaseVehicle vehicle, BaseCustomer customer, DateTime startDate, DateTime endDate)
        {
            Guid = Guid.NewGuid();
            VehicleGuid = vehicle.Guid;
            CustomerGuid = customer.Guid;
            StartDate = startDate;
            EndDate = endDate;
            
            _vehicle = vehicle;
        }

        public Guid Guid { get; private set; }


        
        public Guid VehicleGuid
        {
            get { return _vehicleGuid; }
            private set { _vehicleGuid = value; }
        }
        public Guid CustomerGuid
        {
            get { return _customerGuid; }
            private set { _customerGuid = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            private set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
            private set { _endDate = value; }
        }

        public decimal TotalPrice
        {
            get
            {
                int days = (_endDate - _startDate).Days;
                return _vehicle.BaseRentalPrice * days;
            }
        }




    }
}
