using System;
using System.IO;
using System.Collections.Generic;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string key = line[0];
                        int value = int.Parse(line[1]);
                        if (dic.ContainsKey(key))
                            dic[key] += value;
                        else
                            dic[key] = value;
                        
                    }

                    foreach(var item in dic)
                    {
                        Console.WriteLine(item.Key  + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}
