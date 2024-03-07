using Task2.Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product("Phone", 3000,5);
           product.Detail();

            Console.WriteLine("Endirim faizi daxil edin:");
            int discount=int.Parse(Console.ReadLine());
            product.Discount(discount);
        }
    }
}