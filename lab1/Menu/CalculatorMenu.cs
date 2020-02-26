using System.IO;
using System;
using static Calculator.Calculator;

namespace Menu
{
    /// <summary>
    /// Menu class:
    /// can run console menu and get input numbers for calculator
    /// operations
    /// </summary>
    public class CalculatorMenu
    {

        private decimal result = 0;
        /// <summary>
        /// Start Menu Method:
        /// Launch infinity cycle and wait user input
        /// </summary>
        public void Start()
        {
            while (true)
            {
                const string MenuText = "(1) - Input Number \n(2) - Sum \n(3) - Subtract \n(4) - Multiply\n" +
                "(5) - Divide \n(6) - Print Result \n(7) - Sin"+
                "\n(8) - Cos \n(0) - Exit\n";
                Console.WriteLine(MenuText);
                string inputLine = Console.ReadLine();
                int inputOperation = -1;
                if (!Int32.TryParse(inputLine, out inputOperation))
                {
                    Console.WriteLine("Wrong Input");
                    continue;
                }

                try
                {
                    Operations operation = (Operations)inputOperation;

                    switch (operation)
                    {
                        case Operations.InputNumber:
                            result = InputNumber();
                            WriteResult();
                            break;
                        case Operations.Sum:
                            result = Sum(result,InputNumber());
                            WriteResult();
                            break;
                        case Operations.Substract:
                            result = Subtract(result,InputNumber());
                            WriteResult();
                            break;
                        case Operations.Multiply:
                            result = Multiply(result, InputNumber());
                            WriteResult();
                            break;
                        case Operations.Divide:
                            result = Divide(result,InputNumber());
                            WriteResult();
                            break;
                        case Operations.Sin:
                            result = Sin(InputNumber());
                            WriteResult();
                            break;
                        case Operations.Cos:
                            result = Cos(InputNumber());
                            WriteResult();
                            break;
                        case Operations.Exit:
                            return;
                        case Operations.PrintResult:
                            WriteResult();
                            break;
                        default:
                            Console.WriteLine("Wrong Operation");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
        
        /// <summary>
        /// Write Results Method:
        /// Write cached result
        /// </summary>
        private void WriteResult()
        {
            Console.WriteLine(result);
        }
        /// <summary>
        /// Input Number Method: 
        /// 
        ///Waits for input of a number from the user and
        /// returns it in decimal type
        /// </summary>
        /// <returns>Returns input in decimal type</returns>
        private decimal InputNumber()
        {
            string inputLine = null;
            bool correct = false;
            decimal number = 0;
            while (!correct)
            {
                inputLine = Console.ReadLine();
                if (!Decimal.TryParse(inputLine, out number))
                {
                    Console.WriteLine("Wrong Input");
                    correct = false;
                }
                else
                {
                    correct = true;
                }
            }
            Console.Clear();
            return number;

        }

    }
}