using System;



class Program
{
    static void Main()
    {
        int blockHeight = int.Parse(Console.ReadLine());
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());

        int verticalRecTop = 4 * blockHeight;
        int verticalRecBottom = 0;
        int verticalRecLeft = blockHeight;
        int verticalRecRight = 2 * blockHeight;

        bool isInsideVerticalRec = pointX > verticalRecLeft && pointX < verticalRecRight
            && pointY < verticalRecTop && pointY > verticalRecBottom;

        int horizontalRecTop = blockHeight;
        int horizontalRecBottom = 0;
        int horizontalRecLeft = 0;
        int horizontalRecRight = 3 * blockHeight;

        bool isInsideHorizontalRec = pointX > horizontalRecLeft
            && pointX < horizontalRecRight
            && pointY > horizontalRecBottom
            && pointY < horizontalRecTop;

        if (isInsideVerticalRec || isInsideHorizontalRec)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            bool isOnBorderX = (pointX == verticalRecLeft && pointY <= verticalRecTop && pointY >= verticalRecBottom)
                || (pointX == verticalRecRight && pointY <= verticalRecTop && pointY >= verticalRecBottom)
                || (pointX == horizontalRecLeft && pointY <= horizontalRecTop && pointY >= horizontalRecBottom)
                || (pointX == horizontalRecRight && pointY <= horizontalRecTop && pointY >= horizontalRecBottom);

            bool isOnBorderY = (pointY == verticalRecTop && pointX > verticalRecLeft && pointX < verticalRecRight)
                || (pointY == verticalRecBottom && pointX >= horizontalRecLeft && pointX <= horizontalRecRight)
                || (pointY == horizontalRecTop && pointX >= horizontalRecLeft && pointX <= horizontalRecRight)
                || (pointY == horizontalRecBottom && pointX >= horizontalRecLeft && pointX <= horizontalRecRight);
            if (isOnBorderX || isOnBorderY)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}

