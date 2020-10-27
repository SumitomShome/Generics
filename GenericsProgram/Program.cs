using System;
namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find the maximum");
            int output = MaximumCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
