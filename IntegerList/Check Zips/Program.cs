using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_Zips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = new int[10] {18059,18045,18042,18034,18065,18054,18976,17564,18043,18048};

            Array.Sort(zip);
            Console.WriteLine( "Enter a zip");

            int input= Convert.ToInt32 (Console.ReadLine());
            int searchNumber = Array.BinarySearch(zip, input);


            if (searchNumber < 0)
                Console.WriteLine("The zip is not in area");
            else
                Console.WriteLine("The zip code is in the area");
        
        Console.ReadLine();

        }
    }
}
