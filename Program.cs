using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Looping_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompter();
            PercentPassing();
            OddSum();
            RandomNumbers();

            void Prompter()
            {
                int min, max, number;
                Console.WriteLine("Please enter a minimum:");
                if (!Int32.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("That's not a number");
                }
                Console.WriteLine("Please enter a maximum:");
                if (!Int32.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("That's not a number");
                }
                do
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}: ");
                    if (!Int32.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("That's not a number");
                    }
                } while (number < min || number > max);
                Console.WriteLine("Thank You");
            }

            void PercentPassing()
            {
                int score,loopNum;
                double total,percent;
                total = 0;
                Console.WriteLine("How many scores would you like to input: ");
                if (!Int32.TryParse(Console.ReadLine(), out loopNum))
                {
                    Console.WriteLine("That's not a number");
                }
                for (int i = 1; i <= loopNum; i++)
                {
                    Console.WriteLine("Please enter a score: ");
                    Int32.TryParse(Console.ReadLine(), out score);
                    if (score >= 70)
                    {
                        total = total + 1;
                    }
                }
                percent = total / loopNum * 100;
                Console.WriteLine($"Your percent of passing scores is {percent}%");
            }

            void OddSum()
            {
                int num,sum;
                Console.WriteLine("Please enter a number: ");
                if(!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("That's not a number");
                }
                sum = 0;
                for (int i = 1; i <= num; i = i + 2)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"Your total is: {sum} ");
            }


            void RandomNumbers()
            {
                Random generator = new Random();
                int randMin, randMax, randNum;
                Console.WriteLine("Please enter a minimum:");
                if(!Int32.TryParse(Console.ReadLine(), out randMin))
                {
                    Console.WriteLine("That's not a number");
                }
                Console.WriteLine("Please enter a maximum:");
                if(!Int32.TryParse(Console.ReadLine(), out randMax))
                {
                    Console.WriteLine("That's not a number");
                }

                for(int i = 1; i <= 25; i++)
                {
                    Console.WriteLine(generator.Next(randMin,randMax));
                }
            }

        }
    }
}
