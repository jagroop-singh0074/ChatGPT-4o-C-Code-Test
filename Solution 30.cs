using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        // Define a dictionary for Roman numeral values
        Dictionary<char, int> roman = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        // Traverse the string from left to right
        foreach (char c in s) {
            int currentValue = roman[c];

            // If previous value is less than current, subtract twice the previous value
            if (prevValue < currentValue) {
                total += currentValue - 2 * prevValue;
            } else {
                total += currentValue;
            }

            // Update previous value for the next iteration
            prevValue = currentValue;
        }

        return total;
    }
}
