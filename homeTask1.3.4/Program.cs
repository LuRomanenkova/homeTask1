using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace homeTask1._3
{
    class Program
    {
        public class ReverserClass : IComparer  
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)  
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            while (true)
            {
                Console.WriteLine(@"Please, enter array length, max and min elements of you array.
                                     Please, divide these parameters by space");
                List<int> parameters;
                while (true)
                {
                    parameters = Console.ReadLine().Split().Select((arg) => int.Parse(arg)).ToList();
                    if (parameters.Count() != 3)
                    {
                        Console.WriteLine(@"Wrong count of parameters! 
                                            Please, enter 3 parameters: length, min and max elements");
                    }
                    else
                    {
                        break;
                    }
                }

                int length = parameters[0];
                int minEl = parameters[1] < parameters[2] ? parameters[1] : parameters[2];
                int maxEl = parameters[2] > parameters[1] ? parameters[2]: parameters[1];

                var myArray = new int[length];
                
                Random rnd = new Random();

                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = rnd.Next(minEl, maxEl + 1);
                }
                
                Console.WriteLine(@"Please, enter in what way you want to have your array sorted:
                                    ASC - enter '>', DESC - enter '<'");
                
                string param;
                while (true)
                {
                    param = Console.ReadLine();
                    if (param == ">" || param == "<")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You enter wrong sorting parameter. Please, enter the right one");
                    }
                }

                if (param == "<")
                {
                    Array.Sort(myArray, 0, length, new ReverserClass());
                }
                else
                {
                    Array.Sort(myArray, 0, length);
                }
                
                
                
                Console.WriteLine($@"Array length: {length}; min element: {minEl}; max element: {maxEl};
                                    sorting parameters {param}");
                foreach (var val in myArray)
                {
                    Console.Write(val + " ");
                }
                
                Console.WriteLine();
                
                Console.WriteLine(@"If you do not want to continue generation, please, enter 'exit', 
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