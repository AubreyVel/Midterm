using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userInput = 0;




            Console.Write("Insert Grade here: ");
            userInput = Math.Round(Convert.ToDouble(Console.ReadLine()));

            

            switch (userInput)
            {
                case 90:
                    Console.WriteLine("Your grade is an A");
                    break;
                case 80:
                    Console.WriteLine("Your grade is a B");
                    break;
                case 70:
                    Console.WriteLine("Your grade is a C");
                    break;
                case 60:
                    Console.WriteLine("Your grade is a D");
                    break;
                default:
                    Console.WriteLine("Your grade is an F");
                    break;
            }
            Console.ReadLine();
        }
    }
}
