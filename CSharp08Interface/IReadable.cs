using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp08Interface
{
    internal interface IReadable
    {
        string Content { get; }
        int Pages { get; }
    }
}
