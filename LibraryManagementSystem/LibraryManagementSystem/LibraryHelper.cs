using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            int now = DateTime.Now.Year;
            int result = (int)(now - item.PublicationYear);
            return result;
        }


        
            public static string ToTitleCase(this LibraryItem item)
            {
                   return Char.ToUpper(item.Title[0]) + item.Title.Substring(1).ToLower();
            }
        

    }
}
