using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCases; i++) {
            var input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reverse = new string(charArray);
            
            int length = input.Length;
            
            bool funny = true;
            for (int j = 0; j < length - 1; j++) {
                int firstDiff = Math.Abs(input[j] - input[j + 1]);
                int secondDiff = Math.Abs(reverse[j] - reverse[j + 1]);
                
                if (firstDiff != secondDiff) {
                    funny = false;
                }
            }
            
            if (funny) {
                Console.WriteLine("Funny");
            } else {
                Console.WriteLine("Not Funny");
            }
        }
    }
}