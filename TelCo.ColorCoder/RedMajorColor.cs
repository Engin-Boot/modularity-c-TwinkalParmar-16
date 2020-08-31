using System;
using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class RedMajorColor
    {
        Dictionary<string, int> redMap = new Dictionary<string, int>();
        public string ToStringFormat(Color MajorColor, Color MinorColor)
        {
            redMap.Add("Blue", 1);
            redMap.Add("Orange", 2);
            redMap.Add("Green", 3);
            redMap.Add("Brown", 4);
            redMap.Add("SlateGray", 5);

            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, redMap[MajorColor.Name]);

        }

    }
}
