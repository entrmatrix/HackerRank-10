using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= n; i++) {
            int numberOfSpaces = n - i;
            int numberOfHashes = i;

            string spaces = string.Empty;
            for (int j = 1; j <= numberOfSpaces; j++) {
                 spaces += " ";
            }

            string hashes = string.Empty;
            for (int k = 1; k <= numberOfHashes; k++) {
                hashes += "#";
            }

            Console.WriteLine(spaces + hashes);
        }
    }
}
