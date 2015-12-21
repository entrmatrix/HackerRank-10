using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        var input = Console.ReadLine();
        var output = new StringBuilder();
        foreach (var character in input) {
            var number = int.Parse(character.ToString());
            number++;
            
            if (number == 10) {
                number = 0;
            }
            
            output.Append(number);
        }
        
        Console.WriteLine(output);
    }
}