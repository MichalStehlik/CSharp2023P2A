using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp06Polymorphism
{
    internal class Cat : Animal
    {
        public new string MakeSound()
        {
            return "Mnau";
        }

        public string MakeAngrySound()
        {
            return "Wrrr";
        }

        public override string ToString()
        {
            return "Some Kitty";
        }
    }
}
