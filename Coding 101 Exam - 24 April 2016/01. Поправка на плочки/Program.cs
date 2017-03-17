using System;

class Program
{
    static void Main()
    {
        int lenghtRoom = int.Parse(Console.ReadLine());
        double widthTile = double.Parse(Console.ReadLine());
        double lenghtTile = double.Parse(Console.ReadLine());
        int widthBench = int.Parse(Console.ReadLine());
        int lenghtBench = int.Parse(Console.ReadLine());

        int squareRoom = lenghtRoom * lenghtRoom;
        int squareBench = lenghtBench * widthBench;
        int squareForRepair = squareRoom - squareBench;
        double squareTile = widthTile * lenghtTile;
        double tilesNeeded = squareForRepair / squareTile;
        double timeNeeded = tilesNeeded * 0.2;
        Console.WriteLine(tilesNeeded);
        Console.WriteLine(timeNeeded);

    }
}

