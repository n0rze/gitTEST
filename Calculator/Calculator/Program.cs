using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[1000];

            for (int i = 0; i < 1000; i++)
                array[i] = rand.Next(0, 100);

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(array);

        }
    }
}
