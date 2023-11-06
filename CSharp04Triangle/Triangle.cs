using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp04Triangle
{
    /// <summary>
    /// Class for basic calculations in triangle.
    /// </summary>
    public class Triangle
    {
        #region Sides
        private double _a;

        /// <summary>
        /// Sets and gets side "a" of triangle
        /// Throws ArgumentException for values below or equal to zero. 
        /// </summary>
        public double A
        {
            get { return _a; }
            set
            {
                if (value > 0)
                    _a = value;
                else
                    throw new ArgumentException("Side a must be greater then 0");
            }
        }

        private double _b;
        /// <summary>
        /// Sets and gets side "b" of triangle
        /// Throws ArgumentException for values below or equal to zero. 
        /// </summary>
        public double B
        {
            get { return _b; }
            set
            {
                if (value > 0)
                    _b = value;
                else
                    throw new ArgumentException("Side b must be greater then 0");
            }
        }

        private double _c;
        /// <summary>
        /// Sets and gets side "c" of triangle
        /// Throws ArgumentException for values below or equal to zero. 
        /// </summary>
        public double C
        {
            get { return _c; }
            set
            {
                if (value > 0)
                    _c = value;
                else
                    throw new ArgumentException("Side c must be greater then 0");
            }
        }
        #endregion
        /// <summary>
        /// Sets all three sides of triengle.
        /// Throws ArgumentException for values below or equal to zero. 
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        public void SetSides(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Constructor for common triangle.
        /// Throws ArgumentException for values below or equal to zero. 
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Constructor for equilateral triangle.
        /// Throws ArgumentException for values below or equal to zero. 
        /// </summary>
        /// <param name="side"></param>
        public Triangle(double side)
        {
            A = B = C = side;
        }

        /// <summary>
        /// Gets alpha angle in radians, returns 0 if triangle cannot be constructed
        /// </summary>
        public double Alpha
        {
            get
            {
                return IsExisting() ? Math.Acos((B * B + C * C - A * A) / (2 * B * C)) : 0;
            }
        }

        /// <summary>
        /// /// Gets beta angle in radians, returns 0 if triangle cannot be constructed
        /// </summary>
        public double Beta
        {
            get
            {
                return IsExisting() ? Math.Acos((A * A + C * C - B * B) / (2 * A * C)) : 0;
            }
        }

        /// <summary>
        /// Gets gamma angle in radians, returns 0 if triangle cannot be constructed
        /// </summary>
        public double Gamma
        {
            get
            {
                return IsExisting() ? Math.Acos((A * A + B * B - C * C) / (2 * A * B)) : 0;
            }
        }

        /// <summary>
        /// Gets length of outline. Returns 0 if triangle cannot be constructed.
        /// </summary>
        public double Outline
        {
            get
            {
                return IsExisting() ? A + B + C : 0;
            }
        }

        /// <summary>
        /// Returns total length of outline.
        /// </summary>
        /// <returns>Length of all sides combined. Zero if triangle cannot be constructed.</returns>
        public double GetOutline()
        {
            return Outline;
        }

        /// <summary>
        /// Gets area of triangle. Returns 0 if triangle cannot be constructed.
        /// </summary>
        public double Area
        {
            get
            {
                return IsExisting() ? Math.Sqrt(Outline * (Outline - A) * (Outline - B) * (Outline - C)) : 0;
            }
        }
        /// <summary>
        /// Gets total area of triangle. Returns 0 if triangle cannot be constructed.
        /// </summary>
        /// <returns>Area of triangle. Zero if triangle cannot be constructed.</returns>
        public double GetArea()
        {
            return Area;
        }

        /// <summary>
        /// Static method. Checks if triangle given by sides can be constructed.
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        /// <returns>Bool. True if can be constructed, otherwise returns false.</returns>
        public static bool CanExists(double a, double b, double c)
        {
            double outline = a + b + c;
            double[] sides = new double[] { a, b, c };
            double maxSide = sides.Max();
            return maxSide < (outline - maxSide);
        }

        /// <summary>
        /// Returns information about constructivity of triangle.
        /// </summary>
        /// <returns>True if triangle can be constructed, otherwise false.</returns>
        public bool IsExisting()
        {
            return CanExists(A, B, C);
        }
    }
}
