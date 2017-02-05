using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 0; i < n; i++)
        {
            int leftHalfNumbers = int.Parse(Console.ReadLine());
            leftSum = leftSum + leftHalfNumbers;
        }
        for (int i = 0; i < n; i++)
        {
            int rightHalfNumbers = int.Parse(Console.ReadLine());
            rightSum = rightSum + rightHalfNumbers;

        }
        int difference = Math.Abs(leftSum - rightSum);
        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", rightSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", difference);
        }
    }
}

