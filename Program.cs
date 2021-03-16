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
            int min, max, number;
            Console.WriteLine("Please enter a minimum:");
            Int32.TryParse(Console.ReadLine(), out min);
            Console.WriteLine("Please enter a maximum:");
            Int32.TryParse(Console.ReadLine(), out max);
            do
            {
                Console.WriteLine($"Please enter a number between {min} and {max}: ");
                Int32.TryParse(Console.ReadLine(), out number);
            } while (number <= min);


        }
    }
}
