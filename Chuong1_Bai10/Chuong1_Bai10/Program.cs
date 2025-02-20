using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Các số lẻ nhỏ hơn 100 (trừ 5, 7, 93):");

            for (int i_332 = 1; i_332 < 100; i_332 += 2) 
            {
                if (i_332 == 5 || i_332 == 7 || i_332 == 93)
                    continue;

                Console.Write(i_332 + " ");
            }
            Console.WriteLine(); 
            Console.ReadKey();
        }
    }
}
