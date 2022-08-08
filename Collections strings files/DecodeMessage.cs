private static string DecodeMessage(string[] lines)
{	
	var listOfLines = new List<string>();
	var words = String.Join(" ", lines);
	foreach(var item in words.Split(new[]{" "}, StringSplitOptions.RemoveEmptyEntries))
		if(item.Length > 1 && char.IsUpper(item[0]))
			listOfLines.Insert(0, item);		
	return String.Join(" ", listOfLines);
}
