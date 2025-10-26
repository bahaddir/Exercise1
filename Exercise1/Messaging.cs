using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Exercise1.Validations;

namespace Exercise1
{
    public class Messaging
    {
        
        Repository<Student> stdRepo = new Repository<Student>();
        Repository<Teacher> tchRepo = new Repository<Teacher>();
        Repository<Message> msgRepo = new Repository<Message>();
        Repository<User> userRepo = new Repository<User>();
        private User _currentUser;

        public Messaging()
        {
            stdRepo.Add(new Student("bahadirdgn", "bahadir", "dogan", "baha@a", "12345678", 5));
            userRepo.Add(new Student("bahadirdgn", "bahadir", "dogan", "baha@a", "12345678", 5));
            tchRepo.Add(new Teacher("hoca", "sabo", "pasa", "sabo@pasa", "12345678", 25));
            userRepo.Add(new Teacher("hoca", "sabo", "pasa", "sabo@pasa", "12345678", 25));
        }
        public void Register()
        {
            
            Console.WriteLine("username giriniz");
            string username = Console.ReadLine();
            Console.WriteLine("name giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("surname giriniz");
            string surname = Console.ReadLine();
            Console.WriteLine("email giriniz");
            string email = Console.ReadLine();
            Console.WriteLine("password giriniz");
            string password = Console.ReadLine();
            
            Console.WriteLine("user tipi seciniz 1-ogrenci 2-ogretmen");
            byte usertype=byte.Parse(Console.ReadLine());

            switch (usertype)
            {
                case 1:
                    Console.WriteLine("studentNumber giriniz");
                    int studentNumber = int.Parse(Console.ReadLine());
                    stdRepo.Add(new Student(username, name, surname, email, password, studentNumber));
                    userRepo.Add(new Student(username, name, surname, email, password, studentNumber));

                    Console.WriteLine(new Student(username, name, surname, email, password, studentNumber));
                    break;

                case 2:
                    Console.WriteLine("deneyim yili giriniz");
                    int experienceYear = int.Parse(CheckValidation.CheckValue(Console.ReadLine()));
                    

                    tchRepo.Add(new Teacher(username, name, surname, email, password, experienceYear));
                    userRepo.Add(new Teacher(username, name, surname, email, password, experienceYear));

                    Console.WriteLine(new Teacher(username, name, surname, email, password, experienceYear));
                    break;

                default:
                    break;
            }
        }

        public bool Login()
        {
            Console.WriteLine("username giriniz");
            string _username = Console.ReadLine();
            Console.WriteLine("password giriniz");
            string _password = Console.ReadLine();
            
            var user1 = userRepo.GetAll().FirstOrDefault(u => u.UserName == _username && u.Password == _password);
            

            if (user1 != null) 
            { 
                _currentUser = user1;
                return true;
            }
            else 
            { 
                return false;
            }



        }

        /// <summary>
        /// Mesaj gonderme islemini baslatir
        /// </summary>
        public void SendMessage()
        {
            if (_currentUser != null)
            {
                Console.WriteLine("alici username yaziniz");
                string receiverUsername = Console.ReadLine();
                Console.WriteLine("mesaj yaziniz");
                string content = Console.ReadLine();

                msgRepo.Add(new Message(content, receiverUsername, _currentUser.UserName));
                Console.WriteLine(new Message(content, receiverUsername, _currentUser.UserName));
            }
            else
            {
                Console.WriteLine("lutfen mesaj gondermeden once giris yapiniz");
                Login();
            }
        }

        public void ReadMessage()
        {
            if (_currentUser != null)
            {
                var messages = msgRepo.GetAll().Where(m => m.ReceiverUsername == _currentUser.UserName).ToList();
                
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("lutfen mesaj okumak icin giris yapiniz");
                Login();

            }

        }

        public void Logout()
        {
            if(_currentUser!= null)
            {
                _currentUser = null;
                Console.WriteLine("basariyla cikis yapildi"); 
            }
            else
            {
                Console.WriteLine("herhangi bir giris yapmadiniz");
            }

        }


    }
}
