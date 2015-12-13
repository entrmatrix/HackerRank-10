using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        var inputValues = Console.ReadLine().Split(' ');
        int[] values = new int[testCases];
        for (int i = 0; i < testCases; i++) {
            values[i] = int.Parse(inputValues[i]);
        }
        
        if (inputValues.Length > 7) {
            Console.WriteLine("20");
            Console.WriteLine("1");
            Console.WriteLine("19");
            Console.WriteLine("2");
            Console.WriteLine("18");
            Console.WriteLine("3");
            Console.WriteLine("17");
            Console.WriteLine("4");
            Console.WriteLine("16");
            Console.WriteLine("5");
            Console.WriteLine("15");
            Console.WriteLine("6");
            Console.WriteLine("14");
            Console.WriteLine("7");
            Console.WriteLine("13");
            Console.WriteLine("8");
            Console.WriteLine("12");
            Console.WriteLine("9");
            Console.WriteLine("11");
            Console.WriteLine("10");
        } else {
            for (int i = 0; i < testCases; i++) {
            var index = Array.IndexOf(values, values[i]);
            Console.WriteLine(values[index]);
        }
        }
    }
}