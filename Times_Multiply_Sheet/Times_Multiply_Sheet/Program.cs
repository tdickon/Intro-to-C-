using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_Multiply_Sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num_gen = new Random();

            int num_01 = num_gen.Next(1, 11);
            int num_02 = num_gen.Next(1, 11);

            Console.Write("What is " + num_01 + " * " + num_02 + " equal?: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer != (num_01 * num_02))
            {
                Console.WriteLine("You might need to study some more.");
            }

            else
            {
                int num = num_gen.Next(1, 4);
                switch(num)
                {
                    case 1:
                        Console.WriteLine("You are the best!");
                        break;
                    case 2:
                        Console.WriteLine("You really think you're great, don't you?");
                        break;
                    default:
                        Console.WriteLine("Nice");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
