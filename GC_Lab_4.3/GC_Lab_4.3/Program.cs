using System;

namespace GC_Lab_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeFinder = new PrimeNumbers();

            Console.WriteLine("Welcome to Prime Time!");
            Console.WriteLine("This app will find you any prime, in order, from first prime number on.");
            Console.WriteLine();
            
            do
            {
                Console.Write("Which prime number are you looking for? ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(input, out int num))
                {
                    if (num > 0)
                    {
                        int prime = primeFinder.GetPrime(num);

                        Console.WriteLine($"The number {num} prime is {prime}.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Must enter a number >= 1");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Error: Must enter an integer");
                    Console.WriteLine();
                }


            } while (RunAgain());
        }

        private static bool RunAgain()
        {
            do
            {
                Console.Write("Wanna find another Prime number? (y/n): ");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if ("Yy".Contains(key))
                {
                    Console.WriteLine();
                    return true;
                }
                else if ("Nn".Contains(key))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("type y for yes or n for no");
                }
            } while (true);
        }
    }
}
