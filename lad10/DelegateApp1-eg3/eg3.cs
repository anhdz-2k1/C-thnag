using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DelegateApp1
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void printString(string s);

        public static void WWriteToScreen(string str)
        {
            Console.WriteLine("The string is: {0}", str);

        }

        public static void WriteToFile(String s)
        {
            fs = new FileStream("c:\\massage.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void sendString(printString ps)
        {
            ps("Hello WWord");
        }
        static void Main(string[] arrgs)
        {
            printString ps1 = new printString(WWriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
}
