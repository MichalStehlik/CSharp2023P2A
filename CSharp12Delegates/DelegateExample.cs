using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Delegates
{
    internal class DelegateExample
    {
        public DelegateExample(float a, float b)
        {
            A = a;
            B = b;
        }

        public float Addition(float a, float b) { return a + b; }
        public float Subtraction(float a, float b) { return a - b; }
        public float Multiplication(float a, float b) { return a * b; }
        public float Division(float a, float b) { return a / b; }

        public float Do(NumericOperation op)
        {
            return op(A,B);
        }

        public float A { get; set; }
        public float B { get; set; }
    }

    delegate float NumericOperation(float a, float b);
}
