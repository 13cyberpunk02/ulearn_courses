using System;
namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			while (!robot.Finished)
			{
				MoveToFinish(robot, width, height);
			} 
		}
		
		static void MoveToFinish(Robot robot, int width, int height)
		{			
			int stepCount = width > height ?
				(width - 2) / (height - 2) : (height - 2) / (width - 2);
			Direction secondDir = width > height ? Direction.Down : Direction.Right;

			if(width > height)
				Move(robot, Direction.Right, stepCount);
			else
				Move(robot, Direction.Down, stepCount);
			Move(robot, secondDir, 1);							
		}
		
		static void Move(Robot robot, Direction dir, double stepCount)
		{
			for (int i = 0; i < (int)stepCount; i++)
			{
				if(robot.Finished)
					break;
				robot.MoveTo(dir);
			}
		}
	}
}
