using System;

namespace Action_And_Func
{
    class Program
    {

        //delegate 하나 해보고
        //event / action / lamda / func 해보자
        delegate int MyDelegate(int a, int b);

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subject(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a % b;
        }


        delegate void Moving();
        static void Shot()
        {
            Console.WriteLine("Shot!!!");

        }
        static void Punch()
        {
            Console.WriteLine("Punch!!!");

        }
        static void Jump()
        {
            Console.WriteLine("Jump!!!");

        }
        static void Myact(int a)
        {
            Console.WriteLine($"This is {a}");
        }

        static int fuc(int a)
        {
            Console.WriteLine($"This is {a}");
            return a + 100;
        }
        static void Main(string[] args)
        {
            Action MyMove = Jump;
            MyMove();
            Action<int> act = Myact;
            act(10);
            Func<int, int> MyFunc = fuc;
            int a = MyFunc(100);
            Console.WriteLine(a);
            Func<int, int, int> YourFucn = (a, b) => { Console.WriteLine("Yes Lamda"); return a; };
            int b = YourFucn(10, 10);
            Console.WriteLine(b);
        }
    }
}
