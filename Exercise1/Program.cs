using Exercise1.Validations;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Messaging msg = new Messaging();

            bool loop = true;
            while (loop) {
                Console.WriteLine("islem seciniz\n1-register\n2-login\n3-send message\n4-read message\n5-logout\n6-exit");
                string choice = CheckValidation.CheckValue(Console.ReadLine());
                switch (choice)
                {
                case "1":
                        msg.Register();
                    break;
                case "2":
                        msg.Login();
                    break;
                case "3":
                        msg.SendMessage();
                    break;
                case "4":
                        msg.ReadMessage();
                    break;
                case "5":
                        msg.Logout();
                    break;
                case "6":
                        Console.WriteLine("cikis yapliyor");
                        loop= false;
                        break;
                default:
                    break;
                }
            }

        }
    }
}
