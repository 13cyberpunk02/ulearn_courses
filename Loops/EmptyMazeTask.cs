namespace Mazes
{
	public static class EmptyMazeTask
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
			MoveToDown(robot, height);
			MoveToRight(robot, width);
		}
		
		static void MoveToDown(Robot robot, int height)
		{
			if(robot.Y != height-2)
				robot.MoveTo(Direction.Down);
		}
		
		static void MoveToRight(Robot robot, int width)
		{
			if(robot.X != width-2)
				robot.MoveTo(Direction.Right);
		}
	}
}
