using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
{
    // Contains the major and minor color array.
    // Super class for the subclass ColorMapper and NumberMapper
    class MyColor
    {
        // Array of Major colors
        protected static System.Drawing.Color[] colorMapMajor;

        // Array of minor colors
        protected static System.Drawing.Color[] colorMapMinor;

        // Static constructor required to initialize static variable
        static MyColor()
        {
            colorMapMajor = new System.Drawing.Color[] { System.Drawing.Color.White, System.Drawing.Color.Red, System.Drawing.Color.Black, System.Drawing.Color.Yellow, System.Drawing.Color.Violet };
            colorMapMinor = new System.Drawing.Color[] { System.Drawing.Color.Blue, System.Drawing.Color.Orange, System.Drawing.Color.Green, System.Drawing.Color.Brown, System.Drawing.Color.SlateGray };
        }
    }
}
