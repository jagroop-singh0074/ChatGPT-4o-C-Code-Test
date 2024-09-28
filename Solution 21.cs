using System;
using System.Collections.Generic;

public class Solution {
    public IList<bool> GetResults(int[][] queries) {
        HashSet<int> obstacles = new HashSet<int>();
        List<bool> results = new List<bool>();
        
        foreach (var query in queries) {
            if (query[0] == 1) {
                // Place an obstacle at distance x
                int x = query[1];
                obstacles.Add(x);
            } else if (query[0] == 2) {
                // Check if block of size sz can be placed in the range [0, x]
                int x = query[1];
                int sz = query[2];
                bool canPlace = false;
                
                for (int start = 0; start <= x - sz; start++) {
                    bool isBlocked = false;
                    for (int pos = start; pos < start + sz; pos++) {
                        if (obstacles.Contains(pos)) {
                            isBlocked = true;
                            break;
                        }
                    }
                    if (!isBlocked) {
                        canPlace = true;
                        break;
                    }
                }
                
                results.Add(canPlace);
            }
        }
        
        return results;
    }
}
