using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int divs = 0;

            var numberString = n.ToString();
            foreach (var c in numberString) {
                var intChar = int.Parse(c.ToString());
                if (intChar != 0 && n % intChar == 0) {
                    divs++;
                }
            }

            Console.WriteLine(divs);
            }
        }
    }
