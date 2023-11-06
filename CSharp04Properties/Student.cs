using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp04Properties
{// dědičnost, zapouzdření
    internal class Student : Human // potomek, dceřinná třída
    {
        public Student(string firstName, string lastName, string className)
            : base(firstName, lastName)
        {
            ClassName = className;
            _firstname = "Avatar"; // přístupné jen díky protected
        }
        public string ClassName { get; set; }
    }
}
