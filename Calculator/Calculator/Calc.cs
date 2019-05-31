using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BubbleSort
    {
       public int[] Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j + 1] > mas[j])
                    {
                        f = true;
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp+1;
                    }
                }
                if (!f) break;
            }
            return mas;
        }


        public bool SortTest(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] < mas[++i])
                    return false;
            }
            return true;
        }
    }

    public class Vybor
    {
        public int[] Selection(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                int dummy = list[i];
                list[i] = list[min];
                list[min] = dummy;
            }
            return list;
        }

    }
}
