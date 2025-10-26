using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.Interfaces;

namespace Example2.AbstractClasses
{
    public abstract class BaseCustomer : IEntity
    {
		private string _drivingLicenceType;
		private string _email;
		private string _lastName;
		private string _firstName;

        protected BaseCustomer(string firstName, string lastName, string email, string drivingLicenceType)
        {
			Guid = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DrivingLicenceType = drivingLicenceType;
        }

        public Guid Guid { get; private set; }

        public string FirstName
		{
			get { return _firstName; }
            private set { _firstName = value; }
		}

		public string LastName
		{
			get { return _lastName; }
            private set { _lastName = value; }
		}

		public string Email
		{
			get { return _email; }
            private set { _email = value; }
		}

		public string DrivingLicenceType
		{
			get { return _drivingLicenceType; }
            private set { _drivingLicenceType = value; }
		}
        public override string ToString()
        {
            return $"firstname:{_firstName}\nlastname:{_lastName},\nemail:{_email}\ndrivinglicence type:{_drivingLicenceType}";
        }
	}
}
