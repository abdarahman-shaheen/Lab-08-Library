using Lab_08;

namespace TestLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void add()
        {
            Library l1 = new Library();
            l1.Add("james", "FIRST", "LAST", 100);
            int res = l1.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void BorrowBook()
        {
            Library l1 = new Library();
            l1.Add("james", "FIRST", "LAST", 100);
            l1.Add("josn", "FIRST", "LAST", 200);
            l1.Borrow("james");
            int res = l1.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void BorrowExistingBook()
        {
          
            Library library = new Library();
            library.Add("Book Title", "John", "Doe", 200);

            Book borrowedBook = library.Borrow("Book Title");
//  Assert.IsNotNull(borrowedBook);
            Assert.DoesNotContain(borrowedBook, library);

        }
        [Fact]
        public void borrowBookNull()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);
            Book book = l1.Borrow("4");
            Assert.Equal(book, null);

        }
        [Fact]
        public void ReturnBook()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);
            Book book = l1.Borrow("2");
            l1.Return(book);

            Assert.Contains(book, l1);
        }
        [Fact]
        public void ReturnBookCount()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);
            Book book = l1.Borrow("2");
            l1.Return(book);
            int res = l1.Count;
            Assert.Equal(2, res);
        }
        [Fact]
        public void PackItem_IncreasesCount()
        {
            
            Backpack<string> backpack = new Backpack<string>();


            backpack.Pack("Item");
            Assert.Equal(1, backpack.Count());
        }
        [Fact]
        public void UnpackItem_RemovesItem()
        {
           
            Backpack<string> backpack = new Backpack<string>();
            backpack.Pack("Item");
            string unpackedItem = backpack.Unpack(0);
            Assert.Equal("Item", unpackedItem);
            Assert.Equal(0, backpack.Count());
        }


    }
}