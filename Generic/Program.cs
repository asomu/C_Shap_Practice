using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        class MyList<T>
        {
            private T[] array;
            public MyList()
            {
                array = new T[3];
            }

            //Indexer
            //This class에 index를 사용하겠다. return은 뭐구 set은 뭐다....직접 정의해야 한다.
            public T this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    if (index >= array.Length)
                    {
                        Array.Resize<T>(ref array, index + 1);
                        Console.WriteLine("Array resized : {0}", array.Length);
                    }
                    array[index] = value;
                }
            }
            public int Length
            {
                get { return array.Length; }
            }
        }
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            for (int i = 0; i < str_list.Length; i++)
            {
                Console.WriteLine(str_list[i]);
            }
            Console.WriteLine("");

            var int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            for (int i = 0; i < int_list.Length; i++)
            {
                Console.WriteLine(int_list[i]);
            }
            Console.WriteLine("");
        }
    }
}
