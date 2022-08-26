static Array Combine(params Array[] arrays)
{
	if(arrays.Length == 0)
		return null;
	var type = arrays[0].GetType().GetElementType();
	int summaryLength = 0;
	foreach(var x in arrays)
		summaryLength += x.Length;
	Array myArray = Array.CreateInstance(type, summaryLength);
	int index = 0;	
	foreach(var x in arrays)
	{
		if(x.GetType().GetElementType() != type)
			return null;
		foreach(var el in x)
            myArray.SetValue(el, index++);
	}
	return myArray;		
}
