using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var val = Console.ReadLine();
        var arraySize = Console.ReadLine();
        var array = Console.ReadLine();
        
        var splitArray = array.Split(' ');
        
        for (int i = 0; i < int.Parse(arraySize); i++) {
            if (val == splitArray[i]) {
                Console.WriteLine(i);
            }
        }
    }
}