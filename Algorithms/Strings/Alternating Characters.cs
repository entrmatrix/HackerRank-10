using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++) {
            var line = Console.ReadLine();
            
            var firstChar = line[0];
            List<char> alternating = new List<char>();
            alternating.Add(firstChar);
            
            for (int j = 1; j < line.Length; j++) {
                if (line[j] != firstChar) {
                    alternating.Add(line[j]);
                    firstChar = line[j];
                }
            }
            
            Console.WriteLine(line.Length - alternating.Count);
        }
    }
}