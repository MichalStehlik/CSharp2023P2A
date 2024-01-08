using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Generics
{
    internal class Storage<T>: IEquatable<Storage<T>> where T : IEquatable<T>
    {
        public Storage(T value)
        {
            Value = value;
        }

        public T Value { get; protected set; }

        public bool Equals(Storage<T>? other)
        {
            if (Value == null) return false;
            return Value.Equals(other!.Value);
        }

        public T SetValue(T x) { Value = x; return Value; }
        //public T Add(T x) { Value += x; return Value; }
    }
}
