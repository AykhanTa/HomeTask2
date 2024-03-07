using HomeTask2.Models;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("Username daxil edin:");
            string userName=Console.ReadLine();
            Console.WriteLine("Password daxil edin:");
            string password = Console.ReadLine();
            account.Login(userName, password);

        }
    }
}