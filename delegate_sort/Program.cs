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

        //11.4 형식매개 변수 제약시키기
        //IComparable<T>가 반듯이 구현되어 있는 T를 일반화에 사용할 수 있다는 의미....
        //Icomparable은 int32/double 비롯한 모든 수치 형식과 string이 모두 IComparable을 상속해서 자신보다 크면 -1 같으면 0 작으면 1을 반환한다.
        //1의 의미는 소트에서 위치를 바꿔라...크면 바꾼다..오름차순으로 바꾸겠다는 의미
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
