using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{

    public class Teacher : User
    {
        private int _experienceYear;

        public Teacher(string userName, string name, string surname, string email, string password,int experienceYear) : base(userName, name, surname, email, password)
        {
            ExperienceYear = experienceYear;
        }


        public int ExperienceYear
        {
            get { return _experienceYear; }
            private set
            {
                if (value < 1 || value == null)
                    throw new ArgumentException("experience year must be positive");
                else
                    _experienceYear = value;
            }
        }


        public override string ToString()
        {
            return base.ToString()+$"\nExperience Year{_experienceYear}";
        }
    }

}
