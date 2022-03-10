using System;

namespace Uni_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 1, 3, 2, 5, 8, 10, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("");

            Change(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

        }

        static void Change(int [] numbers)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (min>numbers[i])
                {
                    min = i;
                }
                if (max<numbers[i])
                {
                    max = i;
                }
            }
            numbers[min] = numbers[min] + numbers[max];
            numbers[max] = numbers[min] - numbers[max];
            numbers[min] = numbers[min] - numbers[max];

            

        }
    }
}
