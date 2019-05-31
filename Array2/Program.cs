using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array2
{
    class MyList:IEnumerator, IEnumerable
    {
        private int[] array;
        int position = -1;
        public MyList()
        {
            array = new int[3];
        }

        //Indexer
        //This class에 index를 사용하겠다. return은 뭐구 set은 뭐다....직접 정의해야 한다.
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array resized : {0}", array.Length);
                }
                array[index] = value;
            }
        }
        public object Current
        {
            get
            {
                return array[position];
            }
        }
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i<array.Length;i++)
            {
                yield return (array[i]);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            MyList ML = new MyList();
            ML[0] = 0;
            ML[1] = 1;
            ML[2] = 2;
            ML[3] = 3;
            for(int i = 0; i < 3; i++)
            { 
                Console.WriteLine("MyList 0: {0}", ML[i]);
            }

            foreach (int e in ML)
                Console.WriteLine(e);
        }
    }
}
