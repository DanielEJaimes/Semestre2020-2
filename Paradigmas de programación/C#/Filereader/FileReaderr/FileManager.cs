using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileReaderr
{
    class FileManager
    {
        public static string[] ReadAllLines()
        {
            string path = @"C:\Users\Daniel\Desktop\Aplicaciones\xd.txt";

            if (File.Exists(path))
            {
                string[] alltext = File.ReadAllLines(path);
                return alltext;
            }
            else
            {
                return null;
            }
        }
        

        public static void WriteFile(string append)
        {
            string path = @"C:\Users\Daniel\Desktop\Aplicaciones\xd.txt";
            File.AppendAllText(path, "\n"+append);
        }

    }
}
