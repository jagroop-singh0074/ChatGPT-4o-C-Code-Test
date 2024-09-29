using System;

public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int maxSum = int.MinValue;

        // Try all possible placements of three rooks
        for (int r1 = 0; r1 < m; r1++) {
            for (int r2 = r1 + 1; r2 < m; r2++) {
                for (int r3 = r2 + 1; r3 < m; r3++) {
                    for (int c1 = 0; c1 < n; c1++) {
                        for (int c2 = c1 + 1; c2 < n; c2++) {
                            for (int c3 = c2 + 1; c3 < n; c3++) {
                                int currentSum = board[r1][c1] + board[r2][c2] + board[r3][c3];
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
