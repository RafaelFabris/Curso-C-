using System;
using Interface4.Devices;

namespace Interface4
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My Document");
            p.Print("My Document");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Document");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My Dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
