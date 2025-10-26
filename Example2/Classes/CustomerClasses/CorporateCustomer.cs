using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.AbstractClasses;

namespace Example2.Classes.CustomerClasses
{
    public class CorporateCustomer : BaseCustomer
    {
        public CorporateCustomer(string firstName, string lastName, string email, string drivingLicenceType, string companyName, string taxIdentityNo, int discountRate) : base(firstName, lastName, email, drivingLicenceType)
        {
            CompanyName = companyName;
            TaxIdentityNo = taxIdentityNo;
            DiscountRate = discountRate;
        }

        private string _companyName;
        private string _taxIdentityNo;
        private int _discountRate;

        public string CompanyName
        {
            get { return _companyName; }
            private set { _companyName = value; }
        }
        public string TaxIdentityNo
        {
            get { return _taxIdentityNo; }
            private set { _taxIdentityNo = value; }
        }
        public int DiscountRate
        {
            get { return _discountRate; }
            private set { _discountRate = value; }
        }

    }
}
