using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1;
                double num2;
                double result;

                Console.WriteLine("                                     My Calculator  ");
                Console.WriteLine("                                  ...................");

                Console.Write("\tEnter Number 1:\n ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tEnter Number 2:\n ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("     Choose An Option:");
                Console.WriteLine("\t+:ADD");
                Console.WriteLine("\t-:SUBTRACT");
                Console.WriteLine("\t*:MULTIPLY");
                Console.WriteLine("\t/:DIVIDE");
                Console.Write("Enter an option:");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your Result:\n{num1}+{num2}= " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your Result:\n{num1}-{num2}= " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your Result:\n{num1}*{num2}= " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your Result:\n{num1}/{num2}= " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;


                }
                Console.WriteLine("Do you want to Continue?(Y=yes,N=no):");
            } while (Console.ReadLine().ToUpper()=="Y");
            Console.WriteLine("Bye!"); 
                 Console.ReadKey();
           
        }
    }
}
