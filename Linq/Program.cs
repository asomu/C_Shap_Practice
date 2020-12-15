using System;
using System.Linq;

namespace Linq
{
    class Program
    {

        static void Main(string[] args)
        {        
            
                       
            int[] numbers = { 9, 2, 60, 4, 3};

            var result = (from n in numbers
                          where n > 8
                          orderby n
                          select n).First()
                          ;


                Console.WriteLine(result);

            string myString = new string("first");
            string[] yourString = new string[10];
            yourString[0] = "first";
            string[] myString2 = new string[3] { "first", "second", "third" };
            var result2 = myString2.Single((n)=>n.Length>3);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);

            //}
            Console.WriteLine(result2);
        }
    }
}
