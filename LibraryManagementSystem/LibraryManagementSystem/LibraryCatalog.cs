using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryCatalog
    {

      public Book[] books;

      
        
            Exception CustomBookError = new Exception("Daxil edilən id-ə sahib kitab catalogda yoxdur.");
        public Book this[int index]
        {
            get
            {

                try
                {
                    return books[index];
                }
                catch (Exception ex)
                {
                    throw CustomBookError;
                }


            }
            set { books[index] = value; }
        }
    }
    }

