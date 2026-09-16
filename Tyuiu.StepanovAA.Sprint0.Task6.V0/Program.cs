using Tyuiu.StepanovAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.StepanovAA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"Summary array elements = {DataService.AdditionArray(numsArray)}");
            Console.WriteLine($"Substraction array elements = {DataService.SubstractionArray(numsArray)}");
            Console.WriteLine($"Multiplication array elements = {DataService.MultiplicationArray(numsArray)}");
        }
    }
}
