using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Student : User
    {
        private int _studentNumber;

        

        public Student(string userName, string name, string surname, string email, string password,int studentNumber) : base(userName, name, surname, email, password)
        {
            StudentNumber = studentNumber;
        }


        /// <summary>
        /// returns Student Numbers
        /// </summary>
        public int StudentNumber
        {
            get { return _studentNumber; }
            private set 
            {
                if (value < 1 || value == null)
                    throw new ArgumentException("student number must be positive");
                else
                    _studentNumber = value; 
            }
        }


        public override string ToString()
        {
            return base.ToString()+$"\nStudent Number:{_studentNumber}";
        }
    }
}
