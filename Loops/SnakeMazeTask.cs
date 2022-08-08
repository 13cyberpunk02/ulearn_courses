namespace Mazes
{
	public static class SnakeMazeTask
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
			MoveToRight(robot, width, height);			
			MoveToLeft(robot, width, height);
		}
		
		static void MoveToDown(Robot robot, int height)
		{
			if(robot.Y != height-2)
				RepeatMove(robot, Direction.Down, 2);
		}
		
		static void MoveToRight(Robot robot, int width, int height)
		{
			while(robot.X != width-2)
				robot.MoveTo(Direction.Right);
			MoveToDown(robot, height);
		}
		
		static void MoveToLeft(Robot robot, int width, int height)
		{
			while(robot.X != width - (width - 1))
				robot.MoveTo(Direction.Left);
			MoveToDown(robot, height);
		}
		
		static void RepeatMove(Robot robot, Direction dir, int moveCount)
		{
			for (int i = 0; i < moveCount; i++)
				robot.MoveTo(dir);
		}
	}
}
