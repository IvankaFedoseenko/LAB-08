using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08
{
    internal class Books
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public int Year { get; set; }

        public Books(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
