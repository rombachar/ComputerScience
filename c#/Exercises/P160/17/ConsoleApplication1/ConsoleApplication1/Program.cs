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
            int num;
            while (num < 1000 && 99 < num)
            {
                num = int.Parse(Console.ReadLine());
                int h = num / 100;
                int s = num % 10;
                int t = (num - s) % 100 / 10;
            }
        }
    }
}
