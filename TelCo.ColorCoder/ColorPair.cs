using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
// This class makes a pair of color for major and minor color.
{   class ColorPair
    {
        public Color MajorColor { get; set; }
        public Color MinorColor { get; set; }
        public override string ToString(){

            //for {minor color , painumber}
            if (MajorColor == Color.White){
                WhiteMajorColor w = new WhiteMajorColor();
                return w.ToStringFormat(MajorColor,MinorColor);
                
            }
            if (MajorColor == Color.Red){
                RedMajorColor r = new RedMajorColor();
                return r.ToStringFormat(MajorColor, MinorColor);
                
            }
            if (MajorColor == Color.Black){
                BlackMajorColor b = new BlackMajorColor();
                return b.ToStringFormat(MajorColor, MinorColor);
            }
            if (MajorColor == Color.Yellow)
            {
                YellowMajorColor y = new YellowMajorColor();
                return y.ToStringFormat(MajorColor, MinorColor);
            }
            else
            {
                VioletMajorColor v = new VioletMajorColor();
                return v.ToStringFormat(MajorColor, MinorColor);
            }
            
        }}}
