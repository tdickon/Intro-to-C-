﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Run_Down
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < 11; ++index)
            {
                while ((index % 2) != 0)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}