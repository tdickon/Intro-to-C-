using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_01;
            int num_02;

            Console.Write("Please enter your first number: ");
            num_01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            num_02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers " + num_01 + "/" + num_02 + " = " + (num_01 / num_02));
            int num_03 = (num_01 / num_02);
            
            //Trivial practice with if / else if / else
            if(num_03 < 10)
            {
                Console.WriteLine("Wow you got a small number");
            }

            else if(num_03 > 100)
            {
                Console.WriteLine("Wow you got a big number there.");
            }

            else
            {
                Console.WriteLine("Meh, you're average.");
            }

            Console.ReadKey();
        }
    }
}
