using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod16.Calculator
{
    /// <summary>
    /// The calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Additionals the.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <returns>An int.</returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtractions the.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <returns>An int.</returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Miltiplications the.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <returns>An int.</returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divisions the.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <returns>An int.</returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
