namespace Lab_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Library();
       
            l1.Add("Flower book", "osama", "majed", 22);
            l1.Add("Justin baber", "osama", "majed", 22);

            var b1 = new Backpack<Book>();
          
            b1.Pack(l1.Borrow("Flower book"));
            Console.WriteLine("book in library");
            foreach (Book book in l1)
            {
                Console.WriteLine($" title : {book.Title} || Author :{book.Author}");
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