using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
{
    // Contains the major and minor color array.
    // Super class for the subclass ColorMapper and NumberMapper
    class ColorArray
    {
        // Array of Major colors
        protected static System.Drawing.Color[] colorMapMajor;

        // Array of minor colors
        protected static System.Drawing.Color[] colorMapMinor;

        // Static constructor required to initialize static variable
        static ColorArray()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black,Color.Yellow,Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green,Color.Brown,Color.SlateGray };
        }
    }
}
