using System;
using System.Collections.Generic;
using System.Drawing;


namespace TelCo.ColorCoder
{
    class WhiteMajorColor
    {
        Dictionary<string, int> whiteMap = new Dictionary<string, int>();
        public string ToStringFormat(Color MajorColor, Color MinorColor)
        {
            whiteMap.Add("Blue", 1); 
            whiteMap.Add("Orange", 2);
            whiteMap.Add("Green", 3);
            whiteMap.Add("Brown", 4); 
            whiteMap.Add("SlateGray", 5);

            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, whiteMap[MajorColor.Name]);
        }
    }

    
}
