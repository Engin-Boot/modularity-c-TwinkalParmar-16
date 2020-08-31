using System;
using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class VioletMajorColor
    {
        Dictionary<string, int> violetMap = new Dictionary<string, int>();
        public string ToStringFormat(Color MajorColor, Color MinorColor)
        {
            violetMap.Add("Blue", 1);
            violetMap.Add("Orange", 2);
            violetMap.Add("Green", 3);
            violetMap.Add("Brown", 4);
            violetMap.Add("SlateGray", 5);

            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, violetMap[MajorColor.Name]);
        }
    }
}
