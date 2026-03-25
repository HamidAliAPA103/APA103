using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Interface
{
    internal class Calculation : ICalculation
    {

        public double Calculate(double num1, double num2, char operations)
        {
            switch (operations)
            {
                case '+':
                    return num1 + num2;

                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("0 ra bolme yoxdur ");
                        return 0;
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("bele emeliyyat yoxdur");
                    return 0;

            }
        }

  
    }
}
