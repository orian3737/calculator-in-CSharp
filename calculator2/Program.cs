using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("Hello welcome to the calulator program!");
            Console.WriteLine("Please enter your firsst number!");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Second Number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to use?");
            Console.WriteLine("Please enter a for addition, S for subtraction, m for multiplication or any other key for division.");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else  
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thankyou for using the calculator program!");
            Console.WriteLine("This program was written by Ryan Murzyn on 03/08/2024 my first Program written in C#!");
       
            Console.ReadKey();
        }
    }
}
