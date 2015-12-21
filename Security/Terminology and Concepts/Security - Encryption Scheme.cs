using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var input = int.Parse(Console.ReadLine());
        var output = 1;
        
        for (int i = 1; i <= input; i++) {
            output *= i;
        }
        
        Console.WriteLine(output);
    }
}