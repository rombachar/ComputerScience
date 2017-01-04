using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool idk = false;
            int i = 1;
            while (idk == false)
            {
                if (int.Parse(Console.ReadLine()) % 10 != 0)
                {
                    idk = true;
                    Console.WriteLine("The fake is in the " + i + " stack.");

                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
