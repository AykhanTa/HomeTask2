namespace Task3.Models
{
    public class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Product(int no,string name,int price)
        {
            Name = name;
            Price = price;
            No = no;
        }
    }
}
