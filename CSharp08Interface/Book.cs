using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp08Interface
{
    internal class Book : IReadable, IComparable<Book>
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int Pages { get { return Content.Split(" ").Count(); } }

        public int CompareTo(Book? other)
        {
            return Pages.CompareTo(other.Pages);
        }
    }
}
