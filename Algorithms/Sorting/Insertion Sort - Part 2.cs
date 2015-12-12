using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static void insertionSort(int[] inputArray) {
    for (int i = 0; i < inputArray.Length-1; i++)
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (inputArray[j-1] > inputArray[j])
            {
                int temp = inputArray[j-1];
                inputArray[j-1] = inputArray[j];
                inputArray[j] = temp;
            }
        }
        
        Console.WriteLine(string.Join(" ", inputArray));
    }
}
static void Main(String[] args) {
           
           int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }

           insertionSort(_ar);
    }
}

