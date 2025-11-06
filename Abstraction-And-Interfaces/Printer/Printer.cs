using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_And_Interfaces.Printer
{
    public class Printer : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }
}
