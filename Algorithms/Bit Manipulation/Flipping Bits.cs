using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        for (int t = 0; t < testCases; t++) {
            var item = uint.Parse(Console.ReadLine());
            Console.WriteLine(~item);
        }
    }
}