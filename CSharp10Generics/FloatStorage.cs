using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Generics
{
    internal class FloatStorage
    {
        public FloatStorage(float value)
        {
            Value = value;
        }

        public float Value { get; protected set; }
        public float SetValue(float x) { Value = x; return Value; }
        public float Add(float x) { Value += x; return Value; }
    }
}
