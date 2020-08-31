using System;
using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class BlackMajorColor
    {
        Dictionary<string, int> blackMap = new Dictionary<string, int>();
        public string ToStringFormat(Color MajorColor, Color MinorColor)
        {
            blackMap.Add("Blue", 1);
            blackMap.Add("Orange", 2);
            blackMap.Add("Green", 3);
            blackMap.Add("Brown", 4);
            blackMap.Add("SlateGray", 5);

            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, blackMap[MajorColor.Name]);
        }
    }
}
