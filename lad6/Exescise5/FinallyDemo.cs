using System;
using System.IO;

namespace Exescise5
{
    class FinallyDemo
    {
        static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                outStream = File.OpenWrite("DesttinationFile.txt");
                inStream = File.OpenRead("BogusInputFile.txt"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if(outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("outSteam closed.");
                }
                if (inStream != null)
                {
                    inStream.Close();
                    Console.WriteLine("inStream closed.");
                }
            }
        }
    }
}
