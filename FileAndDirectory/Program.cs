using System;
using System.IO;
using System.Linq;
using static System.Console;
namespace FileAndDirectory
{
    class Program
    {

        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?Good Morning 야후 이걸 250자가 넘으면 어떻게 될까?");
                bw.Write(float.MaxValue);
            }
            using (BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open)))
            {
                WriteLine($"File size : {br.BaseStream.Length} Byte");
                WriteLine($"{br.ReadInt32()}");
                WriteLine($"{br.ReadString()}");
            }
        }

    }
}
