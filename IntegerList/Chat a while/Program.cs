using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat_a_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AreaCode = new int[6] { 262, 414, 608, 715, 815, 920 };

            double [] Rate = new double [6] { 0.07, .10, .05, .16, .24, .14 };

            Console.WriteLine("Enter a area code");

            int UserareaCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter a length of call");

            double time = Convert.ToDouble(Console.ReadLine());
            int search = Array.BinarySearch(AreaCode, UserareaCode);

            if (search < 0)
                Console.WriteLine("invalid area code");
            else
            {
                double userRate = Rate[search];
                double totalCost = userRate * time;
                Console.WriteLine(" the total cost of the call is ${0}", totalCost);
            }

        }
    }
}
