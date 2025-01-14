﻿using System;
using System.IO;

namespace BlockUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\temp\file1.txt";
            string targePath = @"c:\temp\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                using (StreamWriter sw = File.AppendText(targePath)) 
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
