using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_And_Interfaces.Printer
{
    public class MultiFunctionPrinter : IPrintable, IScannnable
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning");
        }

        public void Copy()
        {
            Console.WriteLine("Copying");
        }
    }
}
