using System;

namespace TestMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number From Three Integer Number Using Generic Class And Method with IComparable\n");
            RefactorGenericMax<int> refactorInt = new RefactorGenericMax<int>(12, 23, 45);
            refactorInt.MaxMethod();


            Console.WriteLine("Maximum Number From Three Float Number Using Generic Class And Method with IComparable\n");
            RefactorGenericMax<double> refactorDouble = new RefactorGenericMax<double>(12.52, 23.56, 4.45);
            refactorDouble.MaxMethod();

            Console.WriteLine("Maximum Number From Three Float Number Using Generic Class And Method with IComparable\n");
            RefactorGenericMax<string> refactorString = new RefactorGenericMax<string>("A", "B", "C");  //we can write number also in string
            refactorString.MaxMethod();
        }
    }
}