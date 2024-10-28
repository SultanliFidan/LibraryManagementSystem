using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    abstract class Person
    {
        private static int _id;
        public string Name { get; set; }
        public int Id { get;  }

        protected Person(string name)
        {
            Name = name;
            Id = ++_id;
        }
    }
}
