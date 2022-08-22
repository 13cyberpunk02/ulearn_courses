// Вставьте сюда финальное содержимое файла VectorTask.cs
namespace GeometryTasks
{
	public class Vector
	{
		public double X;
		public double Y;
	}

	public class Geometry
	{
		public static double GetLength(Vector v)
		{
			return System.Math.Sqrt(v.X * v.X + v.Y * v.Y);
		}

		public static Vector Add(Vector v1, Vector v2)
		{
			var res = new Vector();
			res.X = v1.X + v2.X;  
			res.Y = v1.Y + v2.Y;
			return res; 
		}
	}
}
