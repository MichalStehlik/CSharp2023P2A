using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp07Abstract
{
    internal abstract class Media
    {
        public string Title { get; set; }
        public abstract void Open();
        public virtual string Show()
        {
            return Title;
        }
    }
}
