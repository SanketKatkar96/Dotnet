using System;
 class Program
{
   static unsafe void Main(string[] args)
    {
        int number =10;

        Console.WriteLine("before Modification");
        Console.WriteLine("Value: " +number);
        
        Console.WriteLine("Address: " +(IntPtr)(&number));

        int*ptr =&number;
        *ptr = 51;

        Console.WriteLine("\nAfter Modification");
        Console.WriteLine("Value: " + number);
        Console.WriteLine("Value Via Pointer: "   + *ptr);

        Console.WriteLine("\nLearning Complete");
    }
}