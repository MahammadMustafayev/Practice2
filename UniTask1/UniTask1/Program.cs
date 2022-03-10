using System;

namespace UniTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, -2, 1, 4, -6, 8 };
            NegativetoPositive(ref numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }

        static int NegativetoPositive(ref int [] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    numbers[i]=numbers[i] *(-1);
                }          
            }
            return 0;
        }
    }
}
