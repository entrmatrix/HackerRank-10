using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var input = Console.ReadLine();
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        
        foreach (var c in input) {
            if (characterCount.ContainsKey(c)) {
                characterCount[c]++;
            } else {
                characterCount[c] = 1;
            }
        }
        
        bool hasOdd = false;
        bool hasPalindrome = true;
        foreach (var key in characterCount.Keys) {
            if (characterCount[key] % 2 == 0) {
                
            } else {
                if (hasOdd) {
                    hasPalindrome = false;
                }
                hasOdd = true;
            }
        }
        
        if (hasPalindrome) {
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}