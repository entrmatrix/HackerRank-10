using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        var inputs = Console.ReadLine().Split(' ');
        Dictionary<int, int> data = new Dictionary<int, int>();
        
        for (int i = 0; i < inputs.Length; i++) {
            data[i + 1] = int.Parse(inputs[i]);
        }
        
        for (int i = 1; i <= inputs.Length; i++) {
            var next = data[i];
            Console.WriteLine(data[next]);
        }
    }
}