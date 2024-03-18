using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp21Testing
{
    public class Calculator
    {
        /// <summary>
        /// Vrací součet dvou čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Výsledný součet</returns>
        public double Addition(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Vrací rozdíl dvou čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Výsledný rozdíl</returns>
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// Vrací součin dvou čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Výsledný součin</returns>
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// Vrací podíl dvou čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Výsledný podíl</returns>
        /// <exception cref="ArgumentException">Výjimka v případě, že dělíme nulou.</exception>
        public double Division(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Division by zero");
            return a / b;
        }
    }
}
