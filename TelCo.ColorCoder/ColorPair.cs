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
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }}}
