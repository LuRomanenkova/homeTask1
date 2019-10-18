using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace homeTask1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            string action;
            while (true)
            {
                Console.WriteLine("Please, choose and enter one of these actions: +, -, * /.");
                while (true)
                {
                    action = Console.ReadLine();
                    if (action != "+" && action != "-" && action != "*" && action != "/")
                    {
                        Console.WriteLine("Wrong action sign! Please, enter the right one");
                    }
                    else
                    {
                        break;
                    }
                }
                
                
                Console.WriteLine("Please, enter 2 numbers divided by space");
                List<double> numbers;
                while (true)
                {
                    numbers = Console.ReadLine().Split().Select((arg) => double.Parse(arg)).ToList();
                    if (numbers.Count() != 2)
                    {
                        Console.WriteLine("Wrong count of numbers! Please, enter 2 numbers divided by space");
                    }
                    else
                    {
                        break;
                    }
                }
               
                var a = numbers[0];
                var b = numbers[1];

                switch (action)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        if (a == 0 || b == 0)
                        {
                            if (a == 0 && b == 0)
                            {
                                Console.WriteLine($"Oh! I hope you know that we must not divide by zero");
                            }
                            else if (a == 0)
                            {
                                Console.WriteLine($"{a} / {b} = {0}");
                            }
                            else if (b == 0)
                            {
                                Console.WriteLine($"{b} / {a} = {0}");
                            }
                        }
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                }
                
                Console.WriteLine(@"If you do not want to continue calculating, please, enter 'exit',
                                    else 'next' or smth else.");
                var solution = Console.ReadLine();
                if (solution == "exit" || solution == "Exit" || solution == "EXIT")
                {
                    break;
                }
            }
            
        }
    }
}