using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        // About the Problem
        // The 25-pair color code, originally known as even-count color code, 
        // is a color code used to identify individual conductors in twisted-pair 
        // wiring for telecommunications.
        private static void Main(string[] args)
        {
            // test1- To test the color name from the given colorpair number
            TestGetColorFromPairNumber test1 = new TestGetColorFromPairNumber();
            test1.test();

            // test2- To test the colorpair number from the given color
            TestGetPairNumberFromColor test2 = new TestGetPairNumberFromColor();
            test2.test();

        }
    }
}
