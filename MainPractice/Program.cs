using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace MainPractice
{

    class Program
    {
        private static bool CheckPassed(int score)
        {

            if (score >= 60)
                return true;
            else
                return false;
        }

        private static void Print(int value)
        {
            Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Write($"{score} ");
            WriteLine();

            //Sort()
            Array.Sort(scores);
            //ForEach() 배열요소에 동일한 작업을 하게 한다. new Action<int>(Print)  foreach와 동일한 느낌이네....
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine("");

            //차원을 알려주네 1차원 배열이라 Rank의 결과는 1
            WriteLine($"Number of dimensions : {scores.Rank}");

            //Binary 서치해서 index의 위치를 알려준다.
            WriteLine("BinaryReader Seach : 81 is Attribute {0}", Array.BinarySearch<int>(scores, 34));

            //동일하게 서치해서 index를 알려주는데 느린가?
            WriteLine("Linear Search : 90 is at {0}", Array.IndexOf(scores, 34));

            //TrueForAll 지정한 조건에 부합하는 검사한다. 함수를 parameter로 줘야 한다. 그러니까 각 요소의 결과가 모두 true인지 확인하는 함수.
            WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            //FindIndex 지정한 조건에 부합되는 첫번째 조건의 인덱스를 반환하다. 조건의 전부가 아니고 첫번째 인덱스만.
            int index = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60)
                    return true;
                else
                    return false;
            });

            scores[index] = 61;
            //전부 Ture로 반환되니 Ture겠지...
            WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            //지정한 차원의 반환ㄱ 갯수를 반환하다. 0이니까 0차원 1은 없다. exception 발생.
            WriteLine($"Old lenth of scores : {scores.GetLength(0)}");

            //사이즈를 10개로 맞추고 생겨난것은 0으로 채워 넣는다.
            Array.Resize<int>(ref scores, 10);

            WriteLine($"New length of scores : {scores.Length}");


            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine("");

            //3부터 7까지 0...
            Array.Clear(scores, 3, 7);


            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine("");

       
        }
    }
}
