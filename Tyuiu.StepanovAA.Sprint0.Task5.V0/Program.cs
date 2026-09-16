using System.Collections.Concurrent;
using Tyuiu.StepanovAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.StepanovAA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"a + b = {DataService.Addition(1, 5)}");
            Console.WriteLine($"a - b = {DataService.Subtraction(15, 5)}");
            Console.WriteLine($"a * b = {DataService.Multiplication(10, 10)}");
            Console.WriteLine($"a / b = {DataService.Division(9, 3)}");
            Console.WriteLine($"a / b = {DataService.Division(5, 0)}");

        }
    }
}
