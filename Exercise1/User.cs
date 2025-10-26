using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public abstract class User : IUser
    {
        protected string _username;
        protected string _name;
        protected string _surname;
        protected string _password;
        protected string _email;
        protected static int _idCounter = 1;

        protected User(string userName, string name, string surname, string email, string password)
        {
            UserName = userName;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            CreatedAt= DateTime.Now;
            Id= _idCounter++;
            
        }


        
        public int Id { get;}

        public string UserName
        {
            get { return _username; }
            protected set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("username can not be less then 4 characters");
                }
                else 
                {
                    _username = value;
                }
            }
        }
        
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            protected set { _surname = value; }
        }
        public string Email
        {
            get { return _email; }
            protected set
            {
                if (new EmailAddressAttribute().IsValid(value))
                    _email = value;
                else
                    throw new ArgumentException("email must be valid");
            }
        }
        public string Password
        {
            get { return _password; }
            protected set
            {
                if (value.Length < 8) {
                    throw new ArgumentException("password can not be less then 8 characters");
                }

                _password = value; }
        }

        public DateTime CreatedAt { get; }


        public override string ToString()
        {
            return $"username: {_username}\nName:{_name} Surname:{_surname}\nEmail:{_email}\nCreated At:{CreatedAt}";
        }
    }
}
