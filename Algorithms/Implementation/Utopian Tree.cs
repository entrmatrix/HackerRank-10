using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetHeight(n));
        }
    }

    private static int GetHeight(int cycles) {
        int height = 1;
        for (int i = 0; i <= cycles; i++) {
            if (i != 0) {
                if (i%2 != 0) {
                    height = height * 2;
                } else {
                    height++;
                }
            }
        }
        return height;
    }
}
