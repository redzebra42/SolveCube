using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 11; i++)
        {
            string pattern = Console.ReadLine();
            Console.Error.WriteLine(pattern);
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("UNSOLVABLE");
    }
}

// U, L, F, R, B, D => 1, 2, 3, 4, 5, 6

struct Corner
{
    int[] c, face;
}

struct Edge
{
    int[] e, face;
}

struct Center
{
    int c, face;
}