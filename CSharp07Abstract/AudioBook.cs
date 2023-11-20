using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp07Abstract
{
    internal class AudioBook : Book
    {
        public double Length { get; set; }
        public override void Open()
        {
            Console.WriteLine("SSSSSS");
        }
        public override string Show()
        {
            return "AB: " + base.Show();
        }
    }
}
