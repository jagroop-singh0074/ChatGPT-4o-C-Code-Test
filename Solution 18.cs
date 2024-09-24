using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxScore(int[][] grid)
    {
        int Backtrack(int row, HashSet<int> usedValues)
        {
            if (row == grid.Length)
                return 0;

            int maxScore = 0;
            foreach (var value in grid[row])
            {
                if (!usedValues.Contains(value))
                {
                    // Add the value to the used set and calculate the score recursively
                    usedValues.Add(value);
                    int score = value + Backtrack(row + 1, usedValues);
                    maxScore = Math.Max(maxScore, score);
                    // Backtrack: remove the value from the used set
                    usedValues.Remove(value);
                }
            }

            return maxScore;
        }

        return Backtrack(0, new HashSet<int>());
    }

    public static void Main()
    {
        var solution = new Solution();
        
        int[][] grid1 = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 3, 2 },
            new int[] { 1, 1, 1 }
        };
        Console.WriteLine(solution.MaxScore(grid1)); // Output: 8

        int[][] grid2 = new int[][] {
            new int[] { 8, 7, 6 },
            new int[] { 8, 3, 2 }
        };
        Console.WriteLine(solution.MaxScore(grid2)); // Output: 15
    }
}
