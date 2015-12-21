using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        var testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++) {
            var seeds = Console.ReadLine().Split(' ');
            var firstSeed = long.Parse(seeds[0]);
            var secondSeed = long.Parse(seeds[1]);
            List<int> values = new List<int>();
            
            for (int a = 0; a < 10; a++) {
                values.Add(int.Parse(Console.ReadLine()));
            }
            
            for (long x = firstSeed; x <= secondSeed; x++) {
                bool correct = true;
                var r = new JavaRandom(x);
                
                for (int a = 0; a < 10; a++) {
                    var testValue = values[a];
                    var newRandom = r.NextInt(1000);
                    
                    if (testValue != newRandom) {
                        correct = false;
                    }
                }
                
                if (correct) {
                    var output = new StringBuilder();
                    output.Append(x);
                    output.Append(" ");
                    
                    for (int a = 0; a < 10; a++) {
                        output.Append(r.NextInt(1000));
                        output.Append(" ");
                    }
                    
                    Console.WriteLine(output);
                }
            }
        }
    }
    
    class JavaRandom {
        private long seed;
        public JavaRandom(long seed) {
            this.SetSeed(seed);
        }
        public void SetSeed(long seed) {
            this.seed = (seed ^ 0x5DEECE66DL) & ((1L << 48) - 1);
        }
        protected int Next(int bits) {
            seed = (seed * 0x5DEECE66DL + 0xBL) & ((1L << 48) - 1);
            return (int) (seed >> (48 - bits));
        }
        public int NextInt(int n) {
            if ((n & -n) == n) {
                return (int) ((n * (long)this.Next(31)) >> 31);
            }
            
            int bits, val;
            do {
                bits = this.Next(31);
                val = bits % n;
            } while (bits - val + (n - 1) < 0);
            
            return val;
        }
    }
}