public static int MiddleOf(int a, int b, int c)
{
	if (((a >= b) && (a <= c)) || ((a <= b) && (a >=c))) 
		return a;
    else if (((b >= c) && (b <= a)) || ((b <= c) && (b >= a))) 
		return b;
	else 
		return c; 
}
