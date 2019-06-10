using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_sort
{
    class Program
    {
        delegate int Compare<T>(T a, T b);

        static int AccendCompare<T>(T a, T b) where T:IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {         
            return a.CompareTo(b)*-1;
        }
        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

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
            BubbleSort(array, new Compare<int>(AccendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("Sorting Descending...");
            BubbleSort(array2, new Compare<int>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);

        }
    }
}
