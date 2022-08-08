private static void WriteBoard(int size)
{
	string result = "";
	for(int i = 0; i < size; i++)
	{
		for(int j = 0; j < size; j++)
		{
			if( (i+j) % 2 == 0)
				result += "#";
			else
				result += ".";
		}
		result += "\n";
	}
    Console.WriteLine(result);
}
