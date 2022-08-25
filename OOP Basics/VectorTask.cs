using System;
namespace GeometryTasks
{
	public class Segment
	{
		public Vector Begin;
		public Vector End;
		public double GetLength()
		{
			return Geometry.GetLength(this);
		}

		public bool Contains(Vector v)
		{
			return Geometry.IsVectorInSegment(v, this);
		}
	}

	public class Vector
	{
		public double X;
		public double Y;
		public double GetLength()
		{
			return Geometry.GetLength(this);
		}

		public Vector Add(Vector v)
		{
			return Geometry.Add(this, v);
		}

		public bool Belongs(Segment s)
		{
			return Geometry.IsVectorInSegment(this, s);
		}
	}

	public class Geometry
	{		
		public static bool IsVectorInSegment(Vector vector, Segment segment)
		{
			if(vector.X == segment.Begin.X && vector.X == segment.End.X && 
			   vector.Y == segment.Begin.Y && vector.Y == segment.End.Y) 
				return true;
			return((vector.X - segment.Begin.X) * (segment.End.Y - segment.Begin.Y) == 
				   (segment.End.X - segment.Begin.X) * (vector.Y - segment.Begin.Y)) && 	
				   (vector.X >= segment.Begin.X && vector.X <= segment.End.X && vector.Y >= 
					segment.Begin.Y && vector.Y <= segment.End.Y);
        }

		public static double GetLength(Vector v)
		{
			return Math.Sqrt(v.X * v.X + v.Y * v.Y);
		}
		
		public static double GetLength(Segment s)
		{
			double x = (s.End.X - s.Begin.X) * (s.End.X - s.Begin.X);
			double y = (s.End.Y - s.Begin.Y) * (s.End.Y - s.Begin.Y);
			return Math.Sqrt(x + y);
		}

		public static Vector Add(Vector v1, Vector v2)
		{
			return new Vector()
			{
				X = v1.X + v2.X,
				Y = v1.Y + v2.Y
			};
		}
	}
}
