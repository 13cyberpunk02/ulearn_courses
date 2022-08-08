namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			if (count % 10 == 1 && count != 11 && count % 100 != 11) 
				return "рубль";
			else if (count % 100 > 9 && count % 100 < 21) 
				return "рублей";
			else if (count > 9 && count < 21) 
				return "рублей";
			else if (count % 10 > 1 && count % 10 < 5) 
				return "рубля";
			else 
				return "рублей";
		}
	}
}
