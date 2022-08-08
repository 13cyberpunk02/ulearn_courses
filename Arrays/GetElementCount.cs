public static int GetElementCount(int[] items, int itemToCount)
{
	int count = 0;
	foreach(var x in items)
		if(x == itemToCount)
		  count++;	
	return count;
}
