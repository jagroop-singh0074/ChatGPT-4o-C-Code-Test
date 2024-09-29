using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> ValidSequence(string word1, string word2) {
        int n1 = word1.Length;
        int n2 = word2.Length;
        List<int> result = new List<int>();
        int j = 0; // pointer for word2
        bool changed = false; // flag to track if we changed a character

        // Iterate through word1 to find the lexicographically smallest valid sequence
        for (int i = 0; i < n1; i++) {
            if (j < n2 && word1[i] == word2[j]) {
                result.Add(i);
                j++;
            } else if (j < n2 && !changed) {
                // We are allowed to change one character to make it equal
                result.Add(i);
                changed = true;
                j++;
            }

            if (j == n2) {
                break;
            }
        }

        // If we couldn't match word2's length, return an empty array
        if (j < n2) {
            return new List<int>();
        }

        return result;
    }
}
