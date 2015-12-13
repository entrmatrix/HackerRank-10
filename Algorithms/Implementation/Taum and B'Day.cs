using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_b = Console.ReadLine().Split(' ');
            long b = Convert.ToInt64(tokens_b[0]);
            long w = Convert.ToInt64(tokens_b[1]);
            string[] tokens_x = Console.ReadLine().Split(' ');
            long x = Convert.ToInt64(tokens_x[0]);
            long y = Convert.ToInt64(tokens_x[1]);
            long z = Convert.ToInt64(tokens_x[2]);
            
            var blackConversion = y + z;
            var whiteConversion = x + z;
            
            long sum = 0;
            if (blackConversion < x && whiteConversion < y) {
                sum += b * blackConversion;
                sum += w * whiteConversion;
            } else if (blackConversion < x && whiteConversion >= y) {
                sum += b * blackConversion;
                sum += w * y;
            } else if (blackConversion >= x && whiteConversion < y) {
                sum += b * x;
                sum += w * whiteConversion;
            } else {
                sum += b * x;
                sum += w * y;
            }
            Console.WriteLine(sum);
        }
    }
}

