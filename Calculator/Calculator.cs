using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Calc
    {
        public void Addition()
        {
            string userInput1 = "", userInput2 = "";
            bool isNumber1, isNumber2;

            do
            {
                Console.WriteLine("Addition with 2 numbers");
                Console.Write("Insert your first number: ");
                userInput1 = Console.ReadLine();
                Console.Write("Insert your second number: ");
                userInput2 = Console.ReadLine();

                isNumber1 = Double.TryParse(userInput1.ToString(), out _);
                isNumber2 = Double.TryParse(userInput2.ToString(), out _);

                if (isNumber1 == false || isNumber2 == false)
                {
                    Console.Clear();
                    Console.WriteLine("You wrote a not-number value . Try again!\n");
                }
            } while (isNumber1 == false || isNumber2 == false);

            double userInput1Con = Double.Parse(userInput1);
            double userInput2Con = Double.Parse(userInput2);

            double sum = userInput1Con + userInput2Con;
            Console.Write("The total is: ");
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }

        public void Subtraction()
        {
            Console.WriteLine("Subtraction with 2 numbers");
            Console.Write("Insert your first number: ");
            double userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert your second number: ");
            double userInput2 = Convert.ToInt32(Console.ReadLine());

            double sum = userInput1 - userInput2;
            Console.Write("The total is: ");
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }

        public void Multiplication()
        {
            Console.WriteLine("Muliplication with 2 numbers");
            Console.Write("Insert your first number: ");
            double userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert your second number: ");
            double userInput2 = Convert.ToInt32(Console.ReadLine());

            double sum = userInput1 * userInput2;
            Console.Write("The total is: ");
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }

        public void Division()
        {
            double userInput1 = 0, userInput2 = 0;
            do
            {
                Console.WriteLine("Division with 2 numbers");
                Console.Write("Insert your first number: ");
                userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert your second number: ");
                userInput2 = Convert.ToInt32(Console.ReadLine());

                if (userInput1 == 0 || userInput2 == 0)
                {
                    Console.WriteLine("You can't divide by 0. Try again!\n");
                }
            } while (userInput1 == 0 || userInput2 == 0);

            double sum = userInput1 / userInput2;
            Console.Write("The total is: ");
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }

        //To the power off
        public void Potency()
        {
            Console.WriteLine("1 number to the power off another number");
            Console.Write("Insert your first number: ");
            double userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the number you want to power it with: ");
            double userInput2 = Convert.ToInt32(Console.ReadLine());

            double sum = Math.Pow(userInput1, userInput2);
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }

        public void SquareRoot()
        {
            Console.WriteLine("Square root of 1 number");
            Console.Write("Insert your number: ");
            double userInput = Convert.ToInt32(Console.ReadLine());

            double sum = Math.Sqrt(userInput);
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }

        public void Procentage()
        {
            Console.WriteLine("Procentage of 1 number numbers");
            Console.Write("Insert your first number: ");
            double userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert the procentage you want of that number: ");
            double userInput2 = Convert.ToInt32(Console.ReadLine());

            double sum = (userInput1 / 100) * userInput2;
            Console.WriteLine(Math.Round(sum, 2) + "\n");
        }
    }
}
