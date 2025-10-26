using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.AbstractClasses;

namespace Example2.Classes.CustomerClasses
{
    public class IndividualCustomer : BaseCustomer
    {
        public IndividualCustomer(string firstName, string lastName, string email, string drivingLicenceType, DateTime dateOfBirth, string nationalIdenityNo) : base(firstName, lastName, email, drivingLicenceType)
        {
            DateOfBirth = dateOfBirth;
            NationalIdenityNo = nationalIdenityNo;
        }


        private string _nationalIdenityNo;
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            private set { _dateOfBirth = value; }
        }

        public string NationalIdenityNo
        {
            get { return _nationalIdenityNo; }
            private set { _nationalIdenityNo = value; }
        }

    }
}
