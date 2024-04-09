using System;

namespace Calculator
{
    class Program
    {
        static void  Main(string[] args) {
            Console.WriteLine("Wite program to add two numbers");
            Console.WriteLine("first integer input ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second integer input ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is : "+Calculator.add(a,b));
        }
    }
}


