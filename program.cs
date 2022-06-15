using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num1, num2;

            Console.WriteLine("Enter the Operator(+, -, *, /)");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            num2 =Convert.ToDouble(Console.ReadLine());

            switch(op)
			 {
                case '+':
                    Console.WriteLine("{0}+{1} = {2}", num1, num2, (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("{0}-{1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("{0}*{1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero situation");
                    else
                         Console.WriteLine("{0}/{1} = {2}", num1, num2, (num1 / num2));
                    break;

               default:
                    Console.WriteLine("invalid",op);
                    break;
            }
			  Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}