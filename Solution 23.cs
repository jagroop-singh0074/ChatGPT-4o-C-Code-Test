using System;

public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int maxSum = int.MinValue;

        // Check all possible placements of three rooks in different rows and columns
        for (int i1 = 0; i1 < m; i1++) {
            for (int i2 = i1 + 1; i2 < m; i2++) {
                for (int i3 = i2 + 1; i3 < m; i3++) {
                    for (int j1 = 0; j1 < n; j1++) {
                        for (int j2 = j1 + 1; j2 < n; j2++) {
                            for (int j3 = j2 + 1; j3 < n; j3++) {
                                // Calculate the sum of placing rooks in (i1, j1), (i2, j2), and (i3, j3)
                                int currentSum = board[i1][j1] + board[i2][j2] + board[i3][j3];
                                maxSum = Math.Max(maxSum, currentSum);
                            }
                        }
                    }
                }
            }
        }

        return maxSum;
    }
}
