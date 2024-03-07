namespace Task2.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Product(string name, int price,int count)
        {
            Name = name;
            Price = price;
            Count = count;
            
        }
        public void Detail()
        {
            Console.WriteLine($"Product Name: {Name} Price: {Price} Count: {Count}");
        }

        public void Discount(int discount)
        {
            Console.WriteLine(Price-(Price*discount)/100);

        }
    }
}
