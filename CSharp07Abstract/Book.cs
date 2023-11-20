using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp07Abstract
{
    internal class Book : Media
    { 
        public string Author { get; set; }
        public int Chapters { get; set; }
        public override void Open()
        {
            Console.WriteLine("Lup");
        }
        public override string Show()
        {
            return "Book: " + base.Show();
        }
    }
}
