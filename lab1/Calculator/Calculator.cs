using System;

namespace Calculator
{
    /// <summary>
    /// Calculator class:
    /// can sum,subtract,multiply and divide decimal numbers
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Return sum of numbers in decimal
        /// </summary>
        /// <param name="firstNumber">first term in decimal</param>
        /// <param name="secondNumber">second term in decimal</param>
        /// <returns>sum of terms in decimal</returns>
        public static decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Return Subtract of decimal
        /// </summary>
        /// <param name="firstNumber">first term</param>
        /// <param name="secondNumber">second term</param>
        /// <returns>Return Subtract of decimal</returns>
        public static decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Return Multiply of decimal
        /// </summary>
        /// <param name="firstNumber">first term</param>
        /// <param name="secondNumber">second term</param>
        /// <returns>Return Multiply of decimal</returns>
        public static decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// Return Divide of decimal
        /// </summary>
        /// <param name="firstNumber">first term</param>
        /// <param name="secondNumber">second term</param>
        /// <returns>Return Divide of decimal</returns>
        public static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static decimal Sin(decimal number){
            return Convert.ToDecimal(Math.Sin(Convert.ToDouble(number)));
        }
    }
}