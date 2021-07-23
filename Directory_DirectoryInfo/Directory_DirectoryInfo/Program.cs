using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            try
            {
                Console.WriteLine("Directory Separator Char: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("Get Directory Name: " + Path.GetDirectoryName(path));
                Console.WriteLine("Get File Name: " + Path.GetFileName(path));
                Console.WriteLine("Get File Name Without Extension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("Get Extension: " + Path.GetExtension(path));
                Console.WriteLine("Get Full Path: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
