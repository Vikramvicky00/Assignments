using System;


namespace Assignments.oopsandArray_Assigments
{
    internal class SumofArrayElem
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of Elements is: {sum}");
            Console.ReadLine();
        }
    }
}
