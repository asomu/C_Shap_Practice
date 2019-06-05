using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.6.1d에서 가능
//using static System.Console; 
using System.IO;

namespace ThisIsCShop_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            //4.6.1에서 가능.
            //WriteLine(greeting);
            //WriteLine();



            string location = @"C:\test.txt";
            
            using (var sr = new StreamWriter(location))
            {
                //indexOf()
                sr.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
                sr.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o"));

                //LastIndexOf()
                sr.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
                sr.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

                //StartWith()
                sr.WriteLine("StartWith 'Good' : {0}", greeting.StartsWith("Good"));
                sr.WriteLine("StartWith 'Moring' : {0}", greeting.EndsWith("Morning"));

                //Contain()
                sr.WriteLine("Contain 'Evening' : {0}", greeting.Contains("Evning"));
                sr.WriteLine("Contain 'Morngin' : {0}", greeting.Contains("Morning"));

                //Replace()
                sr.WriteLine("Replaced 'Morngin' with 'Evening : {0}", greeting.Replace("Morning", "Evening"));

            }
        }
    }
}
