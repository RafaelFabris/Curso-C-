using System;
using System.Collections.Generic;

namespace Set2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            
            Console.WriteLine("How Many Students for Course A?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int idStudent = int.Parse(Console.ReadLine());
                set.Add(idStudent);
            }
            Console.WriteLine("How Many Students for Course B?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int idStudent = int.Parse(Console.ReadLine());
                set.Add(idStudent);
            }
            Console.WriteLine("How Many Students for Course C?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int idStudent = int.Parse(Console.ReadLine());
                set.Add(idStudent);
            }

            Console.WriteLine("Total Student: " + set.Count);
        }
    }
}
