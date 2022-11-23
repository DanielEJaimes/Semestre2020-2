using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasy
{
    public class FileManager
    {
        public static string[] ReadAllLines()
        {
            string path = @"C:\Users\Daniel\Desktop\Personajes.txt";

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
            string path = @"C:\Users\Daniel\Desktop\Personajes.txt";
            File.AppendAllText(path, append + "\n");
        }
            public static void OverrideFile(string[] contents)
        {
            string path = @"C:\Users\Daniel\Desktop\Personajes.txt";
            File.WriteAllLines(path,contents);
        }
    }
}
