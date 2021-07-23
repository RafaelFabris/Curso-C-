using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
           string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*" , SearchOption.AllDirectories);
                Console.WriteLine("Folder");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newFolder");
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
