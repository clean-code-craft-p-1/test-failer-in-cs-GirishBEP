using System;

namespace misaligned
{
    class StringFormatter
    {
        public string Format(int colourCode, string majorColour, string minorColour)
        {
            return String.Format("{0} | {1} | {2}", colourCode, majorColour, minorColour);
        }
    }
}
