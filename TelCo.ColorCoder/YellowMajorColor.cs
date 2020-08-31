using System;
using System.Collections.Generic;
using System.Drawing;


namespace TelCo.ColorCoder
{
    class YellowMajorColor
    {
        Dictionary<string, int> yellowMap = new Dictionary<string, int>();
        public string ToStringFormat(Color MajorColor, Color MinorColor)
        {
            yellowMap.Add("Blue", 1);
            yellowMap.Add("Orange", 2);
            yellowMap.Add("Green", 3);
            yellowMap.Add("Brown", 4);
            yellowMap.Add("SlateGray", 5);

            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, yellowMap[MajorColor.Name]);
        }
    }
}
