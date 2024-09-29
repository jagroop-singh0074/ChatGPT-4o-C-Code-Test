using System;
using System.Linq;

public class Solution {
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        const int MOD = 1000000007;
        
        // Add the boundary fences at the start and end
        int[] h = new int[hFences.Length + 2];
        int[] v = new int[vFences.Length + 2];
        
        h[0] = 0;
        h[hFences.Length + 1] = m;
        Array.Copy(hFences, 0, h, 1, hFences.Length);
        Array.Sort(h);

        v[0] = 0;
        v[vFences.Length + 1] = n;
        Array.Copy(vFences, 0, v, 1, vFences.Length);
        Array.Sort(v);
        
        // Find the largest gaps between horizontal fences
        int maxHGap = 0;
        for (int i = 1; i < h.Length; i++) {
            maxHGap = Math.Max(maxHGap, h[i] - h[i - 1]);
        }
        
        // Find the largest gaps between vertical fences
        int maxVGap = 0;
        for (int i = 1; i < v.Length; i++) {
            maxVGap = Math.Max(maxVGap, v[i] - v[i - 1]);
        }
        
        // The side length of the largest square that can be formed
        int sideLength = Math.Min(maxHGap, maxVGap);
        
        if (sideLength <= 1) {
            return -1;
        }

        // Return the area modulo 10^9 + 7
        return (int)((long)sideLength * sideLength % MOD);
    }
}
