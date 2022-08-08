private static string ApplyCommands(string[] commands)
{
	var result = new StringBuilder();	
	foreach(var command in commands)
	{
		if(command.Contains("push"))
			result.Append(command.Substring(5));
		if(command.Contains("pop"))
			result.Remove(result.Length - int.Parse(command.Substring(4)),
						 result.Length - (result.Length - int.Parse(command.Substring(4))));
	}
	return result.ToString(); 
}
