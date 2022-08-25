using System.Drawing;
using System.Collections.Generic;
using GeometryTasks;

namespace GeometryPainting
{
    public static class SegmentExtensions
    {
        static private Dictionary<Segment, Color> sc = new Dictionary<Segment, Color>(); 
        public static Color GetColor(this Segment s)
        {
            if(sc.ContainsKey(s))
                return sc[s];
            else
                return Color.Black;
		}

        public static void SetColor(this Segment s, Color c)
        {
            if(sc.ContainsKey(s))
                sc[s] = c;
            else
                sc.Add(s, c);
        }
    }
}
