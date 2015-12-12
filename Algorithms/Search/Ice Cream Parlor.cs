using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        
        for (int t = 0; t < testCases; t++) {
            bool found = false;
            
            var money = int.Parse(Console.ReadLine());
            var flavors = int.Parse(Console.ReadLine());
            var priceStrings = Console.ReadLine().Split(' ');
            List<int> prices = new List<int>();
            foreach (var price in priceStrings) {
                prices.Add(int.Parse(price));
            }
            
            for (int i = 0; i < flavors; i++) {
                var firstFlavor = prices[i];
                
                for (int j = 0; j < flavors; j++) {
                    if (i == j) continue;
                    
                    var secondFlavor = prices[j];
                    
                    if ((firstFlavor + secondFlavor) == money && !found) {
                        Console.WriteLine((i + 1) + " " + (j + 1));
                        found = true;
                    }
                }
            }
        }
    }
}