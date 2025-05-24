using misaligned;
using misaligned.Tests;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MisalignedSpace {
    class Misaligned {
        static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
        static IPrint printer = new ConsolePrinter();
        static StringFormatter formatter = new StringFormatter();
        public int printColorMap() {
            
            int i = 0, j = 0;
            List<string> colorMap = new List<string>();
            for (i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    //Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                    string formattedString = formatter.Format(i * 5 + j, majorColors[i], minorColors[i]);
                    //FormatAndPrint(i * 5 + j, majorColors[i], minorColors[i]);
                    colorMap.Add(formattedString);
                }
            }

            // Added a self test so that the color map is validated before printing within the production code
            ColorMapTester.SelfTest(colorMap, majorColors, minorColors);

            // Print the color map 
            foreach (string color in colorMap)
            {
                printer.Print(color);
            }
            return i * j;
        }
    }
}
