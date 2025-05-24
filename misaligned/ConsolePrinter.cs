using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misaligned
{
    class ConsolePrinter : IPrint
    {
        void IPrint.Print(string s)
        {            
            Console.Write(s);
        }    
    }
}
