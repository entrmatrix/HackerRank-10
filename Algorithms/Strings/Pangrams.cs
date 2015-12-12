using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        var input = Console.ReadLine().ToLower();
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        
        foreach (var inputCharacter in input) {
            if (inputCharacter != ' ') {
                if (lowercase.Contains(inputCharacter)) {
                    lowercase = lowercase.Replace(inputCharacter.ToString(), "");
                }
            }
        }
        
        if (string.IsNullOrEmpty(lowercase)) {
            Console.WriteLine("pangram");
        } else {
            Console.WriteLine("not pangram");
        }
    }
}