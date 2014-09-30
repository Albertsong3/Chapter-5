using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] integerss = new int[5] {5,2,3,4,1};
            Array.Sort(integerss);
           

            for (int i = 0; i < integerss.Length; i++)
            {
                Console.WriteLine(integerss[i]); 
            }


            Array.Reverse(integerss);
            Console.WriteLine();

            for (int x = 0; x < integerss.Length; x++)
            {
                Console.WriteLine(integerss[x]);

            }


            

        }
    }
}
