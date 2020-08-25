using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    // This class is used to test the color name from the given pair number
    class TestGetColorFromPairNumber
    {
        //This function will give some input and Test 
        public void test() {

            int pairNumber = 4;
            ColorPair testPair1 = ColorMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.Brown);
            Debug.Assert(testPair1.ToString() == "MajorColor:White, MinorColor:Brown");


            pairNumber = 5;
            testPair1 = ColorMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == System.Drawing.Color.White);
            Debug.Assert(testPair1.MinorColor == System.Drawing.Color.SlateGray);
            Debug.Assert(testPair1.ToString() == "MajorColor:White, MinorColor:SlateGray");


            pairNumber = 23;
            testPair1 = ColorMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == System.Drawing.Color.Violet);
            Debug.Assert(testPair1.MinorColor == System.Drawing.Color.Green);
            Debug.Assert(testPair1.ToString() == "MajorColor:Violet, MinorColor:Green");
        }
    }
}
