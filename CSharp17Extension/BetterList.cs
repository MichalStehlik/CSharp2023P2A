using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17Extension
{
    internal class BetterList : List<int>
    {
        public int OddCount()
        {
            int i = 0;
            foreach (var item in this)
            {
                if(item % 2 == 1)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
