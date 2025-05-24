using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misaligned
{
    class StringFormatter
    {
        public string Format(int colourCode, string majorColour, string minorColour)
        {
            return String.Format("{0} | {1} | {2}" + Environment.NewLine, colourCode, majorColour, minorColour);
        }
    }
}
