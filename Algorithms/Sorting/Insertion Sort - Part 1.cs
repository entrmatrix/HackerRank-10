using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static void insertionSort(int[] ar, int size) {
    for(int i=size-1;i>=0;i--){
        int val=ar[i];
        int hole=i;
        while(hole>=1 && ar[hole-1]>val){
            ar[hole]=ar[hole-1];
            hole--;
            Console.WriteLine(string.Join(" ", ar));
        }
        ar[hole]=val;
    }        
    Console.WriteLine(string.Join(" ", ar));
}
/* Tail starts here */
    static void Main(String[] args) {
           
           int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }

           insertionSort(_ar, _ar_size);
    }
}

