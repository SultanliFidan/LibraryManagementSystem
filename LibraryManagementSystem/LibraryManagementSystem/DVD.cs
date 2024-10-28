using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class DVD : LibraryItem
    {
        public LibraryLocation Location;
        public DVD(string title, int? publicationYear) : base(title, publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Information: {Title},{PublicationYear} ");
        }
    }
}
