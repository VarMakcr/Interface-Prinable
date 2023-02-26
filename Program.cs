namespace ConsoleApp18
{   
    public interface Printable
    {
        void Print(){}
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Гарри Потер");
            Book book2 = new Book("Зеленая Миля");
            Magazine magazine1 = new Magazine("Небосвод");
            Magazine magazine2 = new Magazine("Pitstop");

            Printable[] printables = { book1, book2, magazine1, magazine2 };
            for (int i = 0; i < printables.Length; i++)
            {
                printables[i].Print();
                
            }
        }
    }
    
    public class Book : Printable
    {
        public string book;

        static void PrintBooks(Printable[] printables, string book1, string book2) 
        {
            Console.WriteLine(book1);
            Console.WriteLine(book2);
        }
        
        public Book(string Book)
        {
            book = Book;
        }
        public void Print()
        {
            Console.WriteLine(book);
        }
    }

    public class Magazine : Printable
    {
        private string magazine;
        static void printMagazines(Printable[] printables, string magazine1, string magazine2)
        {
            Console.WriteLine(magazine1);
            Console.WriteLine(magazine2);
        }
        public Magazine(string magazine)
        {
            this.magazine = magazine;
        }
        public void Print()
        {
           Console.WriteLine(magazine);
        }
    }
}


