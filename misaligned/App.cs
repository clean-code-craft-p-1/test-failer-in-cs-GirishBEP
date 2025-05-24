using misaligned.Tests;
using MisalignedSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misaligned
{
    class App
    {
        static void Main(string[] args)
        {
            StringFormatterTester.Test();
            
            var aligned = new Misaligned();
            int result = aligned.printColorMap();
            Debug.Assert(result == 25);
            
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
