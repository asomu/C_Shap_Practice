using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_sort
{
    class Program
    {
        delegate int Compare(int a, int b);

        static int AccendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i=0;i<DataSet.Length-1;i++)
            {
                for(j=0;j<DataSet.Length-(i+1);j++)
                {
                    if(Comparer(DataSet[j], DataSet[j+1])>0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting Acending...");
            BubbleSort(array, new Compare(AccendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("Sorting Descending...");
            BubbleSort(array2, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);

        }
    }
}
