using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSharp05Exception
{
    internal class Rectangle
    {
        private double _x;

        public Rectangle(double x)
        {
            X = x;
        }

        public double X 
        { 
            get 
            { 
                return _x;
            } 
            set 
            {
                if (value <= 0)
                {
                    //throw new ArgumentOutOfRangeException("X must be above zero");
                    throw new RectangleException("X must be above zero");
                }
                _x = value;
            } 
        }
    }

    class RectangleException : Exception
    {
        public RectangleException()
        {
        }

        public RectangleException(string? message) : base(message)
        {
        }

        public RectangleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RectangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    // https://learn.microsoft.com/en-us/dotnet/standard/exceptions/
}
