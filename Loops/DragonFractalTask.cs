using System.Drawing;
using System;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			Random rnd = new Random(seed);
			double x = 1, y = 0;
			for (int i = 0; i < iterationsCount; i++)
			{	
				var oldX = x;			
				if(rnd.Next(2) == 0)
				{				
					x = GetXCoord(x, y, Math.PI / 4); 
					y = GetYCoord(oldX, y, Math.PI / 4);
				}
				else
				{
					x = GetXCoord(x, y, Math.PI * 3 / 4) + 1;
                    y = GetYCoord(oldX, y, Math.PI * 3 / 4);
				}
				pixels.SetPixel(x,y);
			}			
		}
		
		public static double GetXCoord(double x, double y, double angle)
		{
			return (x * Math.Cos(angle) - y * Math.Sin(angle)) / Math.Sqrt(2);
		}
		
		public static double GetYCoord(double x, double y, double angle)
		{
			return (x * Math.Sin(angle) + y * Math.Cos(angle)) / Math.Sqrt(2);
		}
	}
}
