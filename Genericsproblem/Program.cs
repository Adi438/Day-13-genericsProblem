using System;

namespace TestMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number From Three Float Number\n");
            Console.Write("Enter Num1 : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Num2 : ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Num3 : ");
            double num3 = double.Parse(Console.ReadLine());
            double resut = MaxFloatNumber.MaximumFloatNumber(num1, num2, num3);
            Console.WriteLine(resut);
        }
    }
}