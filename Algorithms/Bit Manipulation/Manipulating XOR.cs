using System;
using System.Collections.Generic;
using System.IO;
class Solution {
/*
 * Complete the function below.
 */
    static int maxXor(int l, int r) {
        int max = 0;
        for (int a = l; a <= r; a++) {
            for (int b = l; b <= r; b++) {
                var xor = a^b;
                if (xor > max) {
                    max = xor;
                }
            }
        }
        
        return max;
    }

    static void Main(String[] args) {
        int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());
        
        int _r;
        _r = Convert.ToInt32(Console.ReadLine());
        
        res = maxXor(_l, _r);
        Console.WriteLine(res);
        
    }
}

