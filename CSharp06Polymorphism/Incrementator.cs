using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp06Polymorphism
{
    internal class Incrementator
    {
        // statický polymorfismus
        public Incrementator(double value) // přetížený konstruktor
        {
            Value = value;
        }

        public Incrementator()
        {
            Value = 0;
        }

        public Incrementator(int value)
        {
            Value = value;
        }

        public Incrementator(double value, int multiplyer)
        {
            Value = value * multiplyer;
        }

        public double Value { get; private set; }

        public void Add(double inc)
        {
            Value += inc;
        }

        public void Add(int inc)
        {
            Value += inc;
        }
        public void Add(double inc, int multiplyer)
        {
            Value += inc * multiplyer;
        }
    }
}
