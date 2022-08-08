public static int[] GetFirstEvenNumbers(int count)
{
	var array = new int[count];
	for(int i = 1; i <= count; i++)
		array[i - 1] += 2 * i;
	return array;
}
