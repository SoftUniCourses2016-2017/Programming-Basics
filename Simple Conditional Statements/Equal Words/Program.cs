﻿using System;



class Program
{
    static void Main(string[] args)
    {
        string word1 = (Console.ReadLine()).ToLower();
        string word2 = (Console.ReadLine()).ToLower();

        if (word1 == word2)
        {
            Console.WriteLine("yes");
        }
        else if (word1 != word2)
        {
            Console.WriteLine("no");
        }
    }
}

