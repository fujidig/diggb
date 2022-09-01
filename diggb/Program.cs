using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read);
            int fileSize = (int)fs.Length;
            byte[] buf = new byte[65536];
            fs.Read(buf, 0, Math.Min(fileSize, 65536));
            Interpreter intp = new Interpreter(buf);
            intp.Run();
        }
    }
}
