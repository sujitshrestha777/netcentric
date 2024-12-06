using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7,6,9,2,3,6,1,4,5 };
            SortAlgo sortAlgo = new SortAlgo();

            Console.WriteLine("Before Sorting:");
            sortAlgo.displayArray(array);

            sortAlgo.bubbleSort(array);

            Console.WriteLine("After Sorting:");
            sortAlgo.displayArray(array);
        }
    }
}