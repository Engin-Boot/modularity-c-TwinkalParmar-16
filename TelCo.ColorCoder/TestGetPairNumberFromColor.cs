using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    // This class is used to test the pair name from the given color name
    class TestGetPairNumberFromColor
    {
        //This function will give some input and Test it.
        public void Test()
        {
            int pairNumber;
            ColorPair testPair2 = new ColorPair();
            testPair2.MajorColor = Color.Yellow;
            testPair2.MinorColor = Color.Green;
            pairNumber = NumberMapper.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);
            Debug.Assert(testPair2.ToString() == "MajorColor:Yellow, MinorColor:Green");

            testPair2.MajorColor = Color.Red;
            testPair2.MinorColor = Color.Blue;
            pairNumber = NumberMapper.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
            Debug.Assert(testPair2.ToString() == "MajorColor:Red, MinorColor:Blue");

        }
    }
}
