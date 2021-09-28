using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recieve users name
            Console.WriteLine("Welcome to Number Analyzer! What is your name?");
            string name = Console.ReadLine();

            bool numberAnalyzer = true;

            while (numberAnalyzer)
            {
                //user will choose a number
                Console.WriteLine($"Choose a number between 1 and 100 {name}!");
                double num = double.Parse(Console.ReadLine());

                //number is outside of range
                if (num < 1 || num > 100)
                {
                    Console.WriteLine($"The number you have chosen is outside the range! Choose again {name}!");
                    continue;
                }

                //even numbers
                else if (num % 2 == 0)
                    {
                        if (num > 2 && num < 25)
                        {
                            Console.WriteLine($"{name}. Your number is {num}. Even and less than 25.");
                        }
                        else if (num > 26 && num < 60)
                        {
                            Console.WriteLine($"{name}.Your number is {num}. Even.");
                        }
                        else if (num >= 60)
                        {
                            Console.WriteLine($"{name}. Your number is {num}. Even.");
                        }
                    }
                //odd numbers
                else if (num % 2 == 1)
                {
                    if (num % 2 == 1)
                    {
                        Console.WriteLine($"{name}. Your number is {num}. Odd.");
                    }
                    
                }
                //ask user if they wish to continue
                Console.WriteLine($"Do you wish to continue {name}? y/n");
                string keepGoing = Console.ReadLine().ToLower();
                if(keepGoing == "y")
                {
                    numberAnalyzer = true;
                }
                else
                {
                    numberAnalyzer = false;
                    Console.WriteLine($"Goodbye {name}!");
                }
                
               
            }
        }
    } 
}