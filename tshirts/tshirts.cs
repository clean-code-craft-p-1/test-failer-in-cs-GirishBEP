using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            // Test boundary value conditions for Size funtion
            Debug.Assert(Size(38) == "M", "Boundary condition for M failed");
            Debug.Assert(Size(42) == "M", "Boundary condition for M failed");
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
