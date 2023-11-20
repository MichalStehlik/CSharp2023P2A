using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp06Polymorphism
{
    internal class Animal : Object
    {
        public virtual string MakeSound()
        {
            return "...";
        }

        public override string ToString()
        {
            return "Some " + base.ToString();
        }
    }
}
