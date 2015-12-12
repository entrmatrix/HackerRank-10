using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);

        int numberOfPositives = 0;
        int numberOfNegatives = 0;
        int numberOfZeroes = 0;

        foreach (var num in arr) {
            if (num > 0) {
                numberOfPositives++;
            }
            else if (num < 0) {
                numberOfNegatives++;
            }
            else {
                numberOfZeroes++;
            }
        }

        Console.WriteLine((float)numberOfPositives / (float)n);
        Console.WriteLine((float)numberOfNegatives / (float)n);
        Console.WriteLine((float)numberOfZeroes / (float)n);
    }
}
