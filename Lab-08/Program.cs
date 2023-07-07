namespace Lab_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Library();
       
            l1.Add("b1", "osama", "majed", 22);
            l1.Add("b2", "osama", "majed", 22);

            var b1 = new Backpack<Book>();
          
            b1.Pack(l1.Borrow("b1"));
            Console.WriteLine("book in library");
            foreach (Book book in l1)
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine("______________________________");
            Console.WriteLine("Book in Bag");
            foreach (var bookInPack in b1)
            {
                Console.WriteLine(bookInPack.Title);
            }
            Console.WriteLine("______________________________");
            Console.WriteLine("Operation");
          l1.Return(b1.Unpack(0));
        }
    }
}