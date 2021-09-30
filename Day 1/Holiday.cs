using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Csharp_Assignment
{
    class Holiday
    {
        public static void Main1()
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 5)
            {
                Console.WriteLine("It is a Working Day");
            }
            else if (n > 5 && n <= 7)
            {
                Console.WriteLine("It is a Holiday");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
