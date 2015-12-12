using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var input = Console.ReadLine().Split(' ');
        var toys = int.Parse(input[0]);
        var money = int.Parse(input[1]);
        
        var toyPriceStrings = Console.ReadLine().Split(' ');
        var toyPrices = new List<int>();
        foreach (var toyPrice in toyPriceStrings) {
            toyPrices.Add(int.Parse(toyPrice));
        }
        
        toyPrices.Sort();
        
        int sum = 0;
        int count = 0;
        foreach (var toyPrice in toyPrices) {
            if ((toyPrice + sum) < money) {
                sum += toyPrice;
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}