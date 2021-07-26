using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface4.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo device print "+ document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing" + document);
        }

        public string Scan()
        {
            return "ComboDevice Scan result";
        }
    }
}
