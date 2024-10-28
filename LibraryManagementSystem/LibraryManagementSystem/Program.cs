namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new Librarian("Fidan");
            librarian.HireDate = DateTime.Now;
            LibraryMember libraryMember = new LibraryMember("Jale");
            libraryMember.MembershipDate = DateTime.Now;

            LibraryLocation libraryLocation = new LibraryLocation { Aisle = 1, Shelf = 2 };
            Book book = new Book("Title",2015);


            book.Genre = BookJenre.Fiction;
            Console.WriteLine(book.ToTitleCase());
            Console.WriteLine(book.CalculateAge());
            book.DisplayInfo();


        }
            
    }
}
