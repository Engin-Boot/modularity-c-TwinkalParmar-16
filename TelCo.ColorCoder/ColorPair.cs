using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
// This class makes a pair of color for major and minor color.
{
    class ColorPair
    {
        private Color majorColor;
        public Color MajorColor
        { get { return majorColor; } set { majorColor = value; } }
        private Color minorColor;
        public Color MinorColor
        { get { return this.minorColor; } set { this.minorColor = value; } }
        public override string ToString()
        {
            String pairNumber = "";
            if (minorColor == Color.Blue && majorColor == Color.White) pairNumber = "1";
            else if (minorColor == Color.Orange && majorColor == Color.White) pairNumber = "2";
            else if (minorColor == Color.Green && majorColor == Color.White) pairNumber = "3";
            else if (minorColor == Color.Brown && majorColor == Color.White) pairNumber = "4";
            else if (minorColor == Color.SlateGray && majorColor == Color.White) pairNumber = "5";
            else if (minorColor == Color.Blue && majorColor == Color.Red) pairNumber = "6";
            else if (minorColor == Color.Orange && majorColor == Color.Red) pairNumber = "7";
            else if (minorColor == Color.Green && majorColor == Color.Red) pairNumber = "8";
            else if (minorColor == Color.Brown && majorColor == Color.Red) pairNumber = "9";
            else if (minorColor == Color.SlateGray && majorColor == Color.Red) pairNumber = "10";
            else if (minorColor == Color.Blue && majorColor == Color.Black) pairNumber = "11";
            else if (minorColor == Color.Orange && majorColor == Color.Black) pairNumber = "12";
            else if (minorColor == Color.Green && majorColor == Color.Black) pairNumber = "13";
            else if (minorColor == Color.Brown && majorColor == Color.Black) pairNumber = "14";
            else if (minorColor == Color.SlateGray && majorColor == Color.Black) pairNumber = "15";
            else if (minorColor == Color.Blue && majorColor == Color.Yellow) pairNumber = "16";
            else if (minorColor == Color.Orange && majorColor == Color.Yellow) pairNumber = "17";
            else if (minorColor == Color.Green && majorColor == Color.Yellow) pairNumber = "18";
            else if (minorColor == Color.Brown && majorColor == Color.Yellow) pairNumber = "19";
            else if (minorColor == Color.SlateGray && majorColor == Color.Yellow) pairNumber = "20";
            else if (minorColor == Color.Blue && majorColor == Color.Violet) pairNumber = "21";
            else if (minorColor == Color.Orange && majorColor == Color.Violet) pairNumber = "22";
            else if (minorColor == Color.Green && majorColor == Color.Violet) pairNumber = "23";
            else if (minorColor == Color.Brown && majorColor == Color.Yellow) pairNumber = "24";
            else /*(minorColor == Color.SlateGray && majorColor == Color.White)*/ pairNumber = "25";
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            //return string.Format("MajorColor:{0}, MinorColor:{1}, PairNumber:{3}", majorColor.Name, minorColor.Name,pairNumber);
        }}}
