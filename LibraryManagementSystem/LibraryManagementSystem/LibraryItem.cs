using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    abstract class LibraryItem
    {
        public LibraryLocation Location;
        public string Title { get; set; }
        public int? PublicationYear { get; set; }

        protected LibraryItem(string title, int? publictionYear)
        {
               Title = title;
            PublicationYear = publictionYear;
        }

       public abstract void DisplayInfo();
       
    }
}
