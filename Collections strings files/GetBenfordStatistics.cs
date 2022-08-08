public static int[] GetBenfordStatistics(string text)
{
    var statistics = new int[10];
	foreach(var x in text.Split(' '))
			if(char.IsDigit(x[0]))
				 statistics[x[0] - '0']++;
    return statistics;
}
