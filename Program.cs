using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Fizzbuzz game. Here's the rules:");
            Console.WriteLine("If number is divisible by 5 print fizz");
            Console.WriteLine("If number is divisible by 3 print buzz");
            Console.WriteLine("If number is divisible by 5 and 3 brint fizzbuzz");
            Console.WriteLine("If number is divisiblke by neither, tell me that");

            while (true)
            {
                Console.WriteLine("[Game Start]: Fizzbuzz: Enter a number.");


                string input = Console.ReadLine();

                if(int.TryParse(input, out int parseInput))
                {
                    if (parseInput % 3 == 0 && parseInput % 5 == 0)
                    {
                        Console.WriteLine("[Game Result] Fizzbuzz!");
                    }
                    else if (parseInput % 5 == 0)
                    {
                        Console.WriteLine("[Game Result] fizz");
                    }
                    else if (parseInput % 3 == 0)
                    {
                        Console.WriteLine("[Game Result] buzz");

                    }
                    else if (parseInput % 5 > 0 || parseInput % 3 > 0) 
                    {
                        Console.WriteLine("[Game Result] Not divisible by either 3 or 5");
                    }
                }
                else 
                {
                    Console.WriteLine("[Error]: Not A Number!");
                }

                Console.WriteLine("[Game Over]: Play Again? Press any key to continue.");
                Console.WriteLine("[Awaiting User Input]");
                Console.ReadLine();
            }
        }
    }
}
