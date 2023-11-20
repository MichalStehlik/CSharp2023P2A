using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp07Abstract
{
    internal class Song : Media
    {
        public double Length { get; set; }
        public string Interpret { get; set; }
        public override void Open()
        {
            Console.WriteLine("Lalalalalala");
        }
        public override string Show()
        {
            return "Song: " + base.Show();
        }
    }
}
