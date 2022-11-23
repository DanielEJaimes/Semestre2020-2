using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Taller_Quiz
{
    class FileManager
    {
        public static string[] ReadAllLines()
        {
            string path = @"C:\Users\Daniel\Desktop\Aplicaciones\usuarios.txt";

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
            string path = @"C:\Users\Daniel\Desktop\Aplicaciones\usuarios.txt";
            File.AppendAllText(path, "\n" + append);
        }
        public static void DeleteFile(string remove)
        {
            string path = @"C:\Users\Daniel\Desktop\Aplicaciones\usuarios.txt";
            File.Delete(path);
        }
    }
}
