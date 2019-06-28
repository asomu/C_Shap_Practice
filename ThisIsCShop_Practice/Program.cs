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

           
            var bw = new BinaryWriter(new FileStream("c.dat",FileMode.Create));
            bw.Write("Good Moring!");
            bw.Write(3);

            bw.Close();
            

            var br = new BinaryReader(new FileStream("c.dat", FileMode.Open));
            Console.WriteLine(br.BaseStream.Length);
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadUInt32());
            
            
            br.Close();
        }

    }
}
