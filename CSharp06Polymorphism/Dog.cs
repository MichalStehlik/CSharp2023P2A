using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp06Polymorphism
{
    internal class Dog : Animal
    {
        // dynamický polymorfismus
        public override string MakeSound()
        {
            return base.MakeSound() + "Haf";
        }

        public string MakeHappySound()
        {
            return "Hafiky";
        }
        public override string ToString()
        {
            return "Some HotDog";
        }
    }
}
