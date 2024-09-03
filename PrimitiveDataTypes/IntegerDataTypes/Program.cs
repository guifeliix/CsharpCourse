
using System;

class Program
{
    static void Main(string[] args)
    {
        int someInteger = 265;
        // Integer -> 2^32
        int intMax = int.MaxValue;
        int intMin = int.MinValue;
        Console.WriteLine("Integer Min and Max example");
        Console.WriteLine(intMax);
        Console.WriteLine(intMin);
        Console.WriteLine("\n");



        uint uintMin = uint.MinValue;
        uint uintMax = uint.MaxValue;

        Console.WriteLine("U Integer Min and Max example");
        Console.WriteLine(uintMax);
        Console.WriteLine(uintMin);
        Console.WriteLine("\n");

        Console.WriteLine("Using Math power of some number, in this case 2^32");
        Console.WriteLine(Math.Pow(2, 32));

        byte someByteNumber = 255;

        byte minByte = byte.MinValue;
        byte maxByte = byte.MaxValue;
        Console.WriteLine("\n");

        Console.WriteLine("Using Byte numbers, does not accept negative numbers");
        Console.WriteLine(minByte);
        Console.WriteLine(maxByte);
        Console.WriteLine("\n");

        Console.WriteLine("sByte accept negative numbers");
        sbyte minsByte = sbyte.MinValue;
        sbyte maxsByte = sbyte.MaxValue;

        Console.WriteLine(minsByte);
        Console.WriteLine(maxsByte);



    }  
}
