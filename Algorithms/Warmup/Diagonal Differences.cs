using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }

        int primarySum = 0;
        int secondarySum = 0;

        for (int rowNumber = 0; rowNumber < a.Count(); rowNumber++) {
            var row = a[rowNumber];
            for (int cellNumber = 0; cellNumber < row.Count(); cellNumber++) {
                var cell = row[cellNumber];

                if (cellNumber == rowNumber) {
                    primarySum += cell;
                }

                if (cellNumber + rowNumber == a.Count() - 1) {
                    secondarySum += cell;
                }
            }
        }

        int finalSum = Math.Abs(primarySum - secondarySum);
        Console.WriteLine(finalSum);
    }
}
