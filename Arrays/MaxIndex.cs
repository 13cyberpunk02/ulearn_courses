public static int MaxIndex(double[] array)
{	
	if (array.Length == 0) return -1;
	var max = double.MinValue;
	int result = 0;
	for (var i = 0; i<array.Length; i++)
		if (array[i] > max)
		{
			max = array[i];
			result = i;
		}
	return result;
}
