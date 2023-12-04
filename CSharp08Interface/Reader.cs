using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp08Interface
{
    internal class Reader
    {
        public string Name { get; set; }
        public string Read(IReadable something)
        {
            return something.Content + " " + something.Pages;
        }
    }
}
