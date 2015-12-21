using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        var input = Console.ReadLine();
        var key = int.Parse(Console.ReadLine());
        var output = new StringBuilder();
        
        foreach (var character in input) {
            var number = int.Parse(character.ToString());
            for (int i = 0; i < key; i++) {
                number++;
                
                if (number == 10) {
                    number = 0;
                }
            }
            output.Append(number);
        }
        
        Console.WriteLine(output);
    }
}