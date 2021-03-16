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
            OddSum();
            RandomNumbers();

            void Prompter()
            {
                int min, max, number;
                Console.WriteLine("Please enter a minimum:");
                Int32.TryParse(Console.ReadLine(), out min);
                Console.WriteLine("Please enter a maximum:");
                Int32.TryParse(Console.ReadLine(), out max);
                do
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}: ");
                    Int32.TryParse(Console.ReadLine(), out number);
                } while (number < min || number > max);
                Console.WriteLine("Thank You");
            }

            void PercentPassing()
            {
                int score;
               
                    Console.WriteLine("Please enter a score: ");
                    Int32.TryParse(Console.ReadLine(), out score);
                
               

            }

            void OddSum()
            {
                int num,sum;
                Console.WriteLine("Please enter a number: ");
                Int32.TryParse(Console.ReadLine(), out num);
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
                Int32.TryParse(Console.ReadLine(), out randMin);
                Console.WriteLine("Please enter a maximum:");
                Int32.TryParse(Console.ReadLine(), out randMax);

                for(int i = 1; i <= 25; i++)
                {
                    Console.WriteLine(generator.Next(randMin,randMax));
                }
            }

        }
    }
}
