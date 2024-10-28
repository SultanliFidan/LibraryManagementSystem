using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book : LibraryItem
    {
       
        public BookJenre Genre { get; set; }

        public Book(string title, int? publictionYear) : base(title, publictionYear)   
        {
            Title = title;
            PublicationYear = publictionYear;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Information: {Title},{PublicationYear} ");
        }
    }

    struct LibraryLocation
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }
    }
}
