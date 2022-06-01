using System;

namespace TestMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number From Three Float Number\n");
            //Console.Write("Enter Num1 : ");
            //string num1 = (Console.ReadLine());
            //Console.Write("Enter Num2 : ");
            //string num2 = (Console.ReadLine());
            //Console.Write("Enter Num3 : ");
            //string num3 = (Console.ReadLine());
            string resut = MaxString.MaximumStringNumber("Praful", "Mayur", "Karan");
            Console.WriteLine(resut);
        }
    }
}