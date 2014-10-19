using ProvaTecnica.Collatz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica.Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceCollatz exeCollazt = new Collatz();
            Console.WriteLine(exeCollazt.exCollatz());
            Console.ReadKey();
        }
    }
}
