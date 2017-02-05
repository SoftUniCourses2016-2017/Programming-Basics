using System;

class OddEvenSum
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[2 * n];
        for (int i = 0; i < 2 * n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sumOdd = 0;
        int sumEven = 0;
        for (int j = 0; j < numbers.Length; j++)
        {
            if (j % 2 == 0)
            {
                sumOdd += numbers[j];
            }

            else
            {
                sumEven += numbers[j];
            }
        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumEven);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumEven - sumOdd));
        }
    }
}