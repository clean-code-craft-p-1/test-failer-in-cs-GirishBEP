using System;

namespace misaligned
{
    class ConsolePrinter : IPrint
    {
        void IPrint.Print(string s)
        {            
            Console.Write(s + Environment.NewLine);            
        }    
    }
}
