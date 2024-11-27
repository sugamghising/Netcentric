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
            int[] array= {6,5,4,3,2,1};
            SortAlgo sortAlgo = new SortAlgo();

            Console.WriteLine("Before Sorting:");
            sortAlgo.displayArray(array);

            sortAlgo.bubbleSort(array);

            Console.WriteLine("After Sorting:");
            sortAlgo.displayArray(array);
        }
    }
}
