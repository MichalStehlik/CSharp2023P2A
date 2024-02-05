using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17Extension
{
    internal static class ListExtensions
    {
        /*
        public static int OddCount(List<int> data)
        {
            int i = 0;
            foreach (var item in data)
            {
                if (item % 2 == 1)
                {
                    i++;
                }
            }
            return i;
        }
        */
        public static int OddCount(this List<int> data)
        {
            int i = 0;
            foreach (var item in data)
            {
                if (item % 2 == 1)
                {
                    i++;
                }
            }
            return i;
        }

        public static int GreaterCount(this List<int> data, int value)
        {
            int i = 0;
            foreach (var item in data)
            {
                if (item > value)
                {
                    i++;
                }
            }
            return i;
        }
        public static int CountItems<T>(this List<T> data)
        {
            return data.Count;
        }

        public static List<int> Odd(this List<int> data)
        {
            List<int> list = new List<int>();
            foreach (var item in data)
            {
                if (item % 2 == 1)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static List<int> GreaterThen(this List<int> data, int value)
        {
            List<int> list = new List<int>();
            foreach (var item in data)
            {
                if (item > value)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
