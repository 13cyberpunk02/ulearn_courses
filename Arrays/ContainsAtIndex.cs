public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
{
	int[] result = new int[subArray.Length];
	Array.Copy(array, i, result, 0, subArray.Length);
	return Enumerable.SequenceEqual(result, subArray);
}
