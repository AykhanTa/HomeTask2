namespace Task3.Models
{
    internal class Book : Product
    {
        public string Genre { get; set; }

        
        public Book(int no, string name,int price,string genre) : base(no,name,price)
        {
            Genre=genre;
        }
    }
}
