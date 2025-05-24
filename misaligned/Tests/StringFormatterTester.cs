using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace misaligned.Tests
{
    internal static class StringFormatterTester
    {
        static IPrint printer = new ConsolePrinter();
        static StringFormatter formatter = new StringFormatter();
        public static void Test()
        {
            int i = 1;
            string formattedString = formatter.Format(i, "White", "Orange");
            string[] values = formattedString.Split('|');
            Debug.Assert(values.Length == 3, "Formatted string should have 3 parts");
            Debug.Assert(values[0] == "1", "First part should be the code");
            Debug.Assert(values[1] == "White", "Second part should be the major color");
            Debug.Assert(values[2] == "Orange", "Third part should be the minor color");
            Console.WriteLine(formattedString);
        }

    }
}
