using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace homeTask1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please, choose one of these formulas end enter its number!");
            Console.WriteLine("1. y = sqrt(1 + b) + sqrt(1 + sqr(a)), you should enter b and a");
            Console.WriteLine("2. y = sqr(2*Sin(a) + 3*Cos(b)) + sqrt(a - b)/ sqr(a + b), you should enter b and a");
            Console.WriteLine("3. y = tg(a/2) + tg(b/2), you should enter b and a");
            Console.WriteLine("4. y = sum(a*(a/456) - 10 * a^3), where a is from 1 to b.");

            int num;
            while (true)
            {
                num = Convert.ToInt16(Console.ReadLine());
                if (num == 1 || num == 2 || num == 3 || num == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You are mistaken! Please, choose one of offered variants");
                }
            }
            
            Console.WriteLine("Please, enter parameters");
            
            List<double> numbers;
            while (true)
            {
                numbers = Console.ReadLine().Split().Select((arg) => double.Parse(arg)).ToList();
                if (numbers.Count() != 2)
                {
                    if (numbers.Count() == 1 && num == 4)
                    {
                        break;
                    }
                    Console.WriteLine("Wrong count of numbers! Please, enter 2 numbers divided by space");
                }
                else
                {
                    break;
                }
            }

            double a = numbers[0];
            double b = 1;
            if (num != 4)
            {
                b = numbers[1];
            }


            switch (num)
            {
                case 1:
                    if (b < -1)
                    {
                        Console.WriteLine("Error, 1 + b must be > 0; ");
                        break;
                    }
                    Console.WriteLine($"y = {Math.Round(Math.Sqrt((1 + b)) + Math.Sqrt(1 + Math.Sqrt(a)), 3)}");
                    break;
                case 2:
                    if (a < b)
                    {
                        Console.WriteLine("Error, a - b must be > 0; ");
                        break;
                    }
                    Console.WriteLine($@"y = 
                     {Math.Round(Math.Pow(2*Math.Sin(a) + 3*Math.Cos(b), 2) + Math.Sqrt(a - b)/Math.Pow(a + b, 2), 3)}");
                    break;
                case 3:
                    Console.WriteLine($"y = {Math.Round(Math.Tan(a/2) + Math.Tan(b/2), 3)}");
                    break;
                case 4:
                    if (b < 1)
                    {
                        Console.WriteLine("Error, b must be >= 1; ");
                        break; 
                    }

                    double sum = 0;
                    for (int i = 1; i <= b; i++)
                    {
                        sum += Math.Round(i * (i / 456) - 10 * Math.Log(Math.Pow(i, 3)), 3);
                    }
                    Console.WriteLine($@"y = {sum}");
                    break;
            }
            
            Console.WriteLine(@"Thanks for testing our calculation!
                                If you want to test it once more time, please, restart our program!");
        }
    }
}