using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        var line = Console.ReadLine().Split(' ');
        List<int> values = new List<int>();
        
        bool isBijective = true;
        foreach (var val in line) {
            int result = int.Parse(val);
            if (values.Contains(result)) {
                isBijective = false;
            } else {
                values.Add(result);
            }
        }
        
        if (isBijective) {
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}