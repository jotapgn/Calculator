using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
       
        enum Menu { Addition = 1, Subtraction, Multiplication, Division, Exponent, SquareRoot, Exit };
        static void Main(string[] args)
        {
            bool chooseLeft = false;
            while (!chooseLeft)
            {
                Console.WriteLine("=== Welcome to the Calculator, select one of the options below: ===");
                Console.WriteLine("1-Addition\n2-Subtraction\n3-Multiplication\n4-Division\n5-Exponent\n6-SquareRoot\nExit");
                Menu option = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case Menu.Addition:
                        Addition();
                        break;
                    case Menu.Subtraction:
                        Subtraction();
                        break;
                    case Menu.Multiplication:
                        Multiplication();
                        break;
                    case Menu.Division:
                        Division();
                        break;
                    case Menu.Exponent:
                        Exponent();
                        break;
                    case Menu.SquareRoot:
                        SquareRoot();
                        break;
                    case Menu.Exit:
                        chooseLeft = true;
                        break;
                }
            }

        }
        static void Addition()
        {
            Console.WriteLine("=== Sum of two numbers: === ");
            Console.WriteLine("Type the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to return to Menu");
            Console.ReadLine();
        }
        static void Subtraction()
        {
            Console.WriteLine("=== Subtraction of two numbers: ===");
            Console.WriteLine("Type the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 - num2;
            Console.WriteLine($"The result of the operation is: {result}");
            Console.WriteLine("Press ENTER to return to Menu");
            Console.ReadLine();
        }
        static void Multiplication()
        {
            Console.WriteLine("=== Multiplication of two numbers: ===");
            Console.WriteLine("Type the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine($"The result of the operation is: {result}");
            Console.WriteLine("Press ENTER to return to Menu");
            Console.ReadLine();
        }
        static void Division()
        {
            Console.WriteLine("=== Division of two numbers: ===");
            Console.WriteLine("Type the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            float result = (float)num1 / (float)num2;
            Console.WriteLine($"The result of the operation is {result}");
            Console.WriteLine("Press ENTER to return to Menu");
            Console.ReadLine();
        }
        static void Exponent()
        {
            Console.WriteLine("=== Exponentiation ===");
            Console.WriteLine("Type the base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the number to be the exponent");
            int exponent = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(baseNum, exponent);
            Console.WriteLine($"The result of the operation is {result}");
            Console.WriteLine("Press ENTER to return to Menu");
            Console.ReadLine();
        }
        static void SquareRoot()
        {
            Console.WriteLine("=== Square Root ===");
            Console.WriteLine("Type the number: ");
            int num = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(num);
            Console.WriteLine($"The result of the operation is {result}");
            Console.WriteLine("Press ENTER to return to Menu");
            Console.ReadLine();
        }
    }
}
