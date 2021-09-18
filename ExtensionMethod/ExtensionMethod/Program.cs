using System;


namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 9, 18, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Hello World";
            Console.WriteLine(s1.Cut(5));
;        }
    }
}
