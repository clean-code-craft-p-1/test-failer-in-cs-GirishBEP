using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace misaligned.Tests
{
    static class ColorMapTester
    {
        static void SplitColorMap(List<string> colorMap, out List<int> codes, out List<string> majorColorsLocal, out List<string> minorColorsLocal)
        {
            codes = new List<int>();
            majorColorsLocal = new List<string>();
            minorColorsLocal = new List<string>();
            foreach (string entry in colorMap)
            {
                string[] parts = entry.Split('|');
                Debug.Assert(parts.Length == 3, "Each entry must have 3 parts separated by '|'");
                int code = int.Parse(parts[0].Trim());
                string majorColor = parts[1].Trim();
                string minorColor = parts[2].Trim();
                codes.Add(code);
                majorColorsLocal.Add(majorColor);
                minorColorsLocal.Add(minorColor);
            }
        }
        public static void SelfTest(List<string> colorMap, string[] majorColors, string[] minorColors)
        {
            // Split each string in colorMap into 3 parts
            List<int> codes = new List<int>();
            List<string> majorColorsLocal = new List<string>();
            List<string> minorColorsLocal = new List<string>();

            SplitColorMap(colorMap, out codes, out majorColorsLocal, out minorColorsLocal);

            // Check if codes contain all numbers
            for (int i = 1; i <= majorColors.Length * minorColors.Length; i++)
            {
                Debug.Assert(codes.Contains(i), $"Code {i} is missing in the color map");
            }

            // Check if majorColors contain all major colors            
            foreach (string color in majorColorsLocal)
            {
                Debug.Assert(majorColors.Contains(color), $"Major color {color} is missing in the color map");
            }

            // Check if minorColors contain all minor colors            
            foreach (string color in minorColorsLocal)
            {
                Debug.Assert(minorColors.Contains(color), $"Minor color {color} is missing in the color map");
            }

            // Ensure each entry is a valid combination of major and minor colors
            List<string> concatenatedColors = new List<string>();
            foreach (string entry in colorMap)
            {
                string[] parts = entry.Split('|');
                string majorColor = parts[1].Trim();
                string minorColor = parts[2].Trim();
                concatenatedColors.Add($"{majorColor} {minorColor}");
            }
            // validate that strings in concatenatedColors are unique strings
            HashSet<string> uniqueColors = new HashSet<string>(concatenatedColors);
            Debug.Assert(uniqueColors.Count == concatenatedColors.Count,
                "There are duplicate color combinations in the color map");
        }
    }
}
