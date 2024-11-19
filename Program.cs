using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 20;
            Console.WriteLine($"Original var1: {var1}");
            Console.WriteLine($"Original var2: {var2}");
            var1 = var1 + var2;  
            var2 = var1 - var2; 
            var1 = var1 - var2;
            Console.WriteLine($"Swapped var1: {var1}");
            Console.WriteLine($"Swapped var2: {var2}");
        }
                
        
    }
}
