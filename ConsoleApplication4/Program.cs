using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int boyut; 
            Console.Write("Baklava diliminin boyutunu giriniz = ");
            boyut = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            for (int i = 0; i <= boyut; i++)
            {
                for (int j = 0; j <= (boyut + 1) - i; j++)
                    Console.Write(" ");  
                for (int k = 0; k <= 2 * i - 2; k++)
                    Console.Write("*");
                Console.WriteLine();  
            }
            for (int m = 0; m <= boyut; m++)
            {  
                for (int n = 0; n <= m; n++)
                   Console.Write(" ");
                for (int z = m * 2; z <= boyut * 2; z++)
                    Console.Write("*");  
                Console.WriteLine();
            }
            Console.ReadKey();  

        }
    }
}
