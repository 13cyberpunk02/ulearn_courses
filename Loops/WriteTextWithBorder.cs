private static void WriteTextWithBorder(string text)
{
	string result = WriteStartEnd(text);
	result += "\n";
	result += "| " + text + " |\n";
	result += WriteStartEnd(text);
	Console.WriteLine(result);
}
private static string WriteStartEnd(string text)
{
	string res = "+";
	for(int i = 0; i < text.Length + 2; i++)
		res += "-";
	res += "+";
	return res;
}
