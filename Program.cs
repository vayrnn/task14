using LibraryB;
using LibraryC;
using System;

class Program
{
    static void Main()
    {
        var serviceB = new ServiceB();
        var serviceC = new ServiceC();

        Console.WriteLine(serviceB.GetMessage());
        Console.WriteLine(serviceC.GetMessage());
    }
}
