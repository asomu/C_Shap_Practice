using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace ZipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"c:\zip\item";
            string extrctPath = @"c:\zip\extract";
            string zipPath = @"c:\zip\result.zip";
            string zipPath2 = @"c:\zip\result.zip";
            if (!File.Exists(zipPath))
            {

                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            else
            {                
                var randomN = new Random();
                var timeNow = DateTime.Now;


                zipPath = zipPath.Insert(zipPath.IndexOf(".zip"), string.Format("_{0:mm_ss}", timeNow));
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }

            if(!Directory.Exists(extrctPath))
            {
                ZipFile.ExtractToDirectory(zipPath, extrctPath);
            }
            else
            {
                extrctPath = extrctPath.Insert(extrctPath.Length, string.Format("_{0:mm_ss}", DateTime.Now));
                ZipFile.ExtractToDirectory(zipPath, extrctPath);
            }

            var a = Path.GetDirectoryName(zipPath);
            var b = Path.GetFileNameWithoutExtension(zipPath);
            var c = Path.GetFullPath(b);
            var d = Path.GetFileName(c);
            var e = Path.ChangeExtension(zipPath, ".gzip");
            var f = new FileInfo(zipPath);
            f.MoveTo(e);



        }
    }
}
