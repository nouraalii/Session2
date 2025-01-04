using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo
{
    class Library
    {
        public string Name { get; set; }
        public Book book { get; set; } 
    }

    class Book
    {
        public string Title { get; set; }

        public string code { get; set; }

        public Author author { get; set; }
    }

    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
