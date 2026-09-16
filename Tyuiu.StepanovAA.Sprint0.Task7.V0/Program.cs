using Tyuiu.StepanovAA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.StepanovAA.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sprint #0 | Completed: Stepanov A. A. | SMARTb-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Sprint #0                                                               *");
            Console.WriteLine("* Topic: Creating a final decision for the sprint                         *");
            Console.WriteLine("* Task #7                                                                 *");
            Console.WriteLine("* Option #0                                                               *");
            Console.WriteLine("* Completed: Stepanov Artem Aleksandrovich | SMARTb-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* CONDITION:                                                              *");
            Console.WriteLine("* Write a console program in C# that sums the values of two               *");
            Console.WriteLine("* identical arrays of equal length.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* INITIAL DATA:                                                           *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Value of array elements #1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Value of array elements #2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RESULT:                                                                 *");
            Console.WriteLine("***************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Summary of array elements =");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Error! Arrays have a different number of elements");
            }
        }
    }
}
