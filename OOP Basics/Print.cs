public static void Print(params Object[] obj)
{
    for(var i=0; i<obj.Length; i++){
        if (i > 0) 
            Console.Write(", ");
        Console.Write(obj[i]);
    }
    Console.WriteLine();
}
