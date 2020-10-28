using System;
using static GenericsProgram.FindMaximum;
namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 11, 22, 33, 12, 95, 84 };
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            genericInt.PrintMaxValue();
            double[] doubleArray = { 111.1, 22.45, 78.56, 95.5, 84.8 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Apple", "Peach", "Banana", "Mango", "Jackfruit" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();
        }
    }
}
