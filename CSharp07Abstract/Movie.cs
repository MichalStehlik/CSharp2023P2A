using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp07Abstract
{
    internal class Movie : Media
    {
        public double Length { get; set; }
        public override void Open()
        {
            Console.WriteLine("20th Century Fox");
        }
        public override string Show()
        {
            return "Movie: " + base.Show();
        }
    }
}
