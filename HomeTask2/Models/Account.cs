namespace HomeTask2.Models
{
    internal class Account
    {
        public string UserName;
        public string Password;

        public void Login(string username,string password)
        {
            if (username=="Admin" && password=="AdminEA18yr@")
            {
                Console.WriteLine("Giris ugurludur.");
            }
            else
            {
                Console.WriteLine("Email ve password sehvdir");
            }
        }

    }
}
