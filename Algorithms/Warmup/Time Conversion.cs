using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        var dateTime = DateTime.Parse(time);

        Console.WriteLine(dateTime.ToString("HH:mm:ss"));
    }
}
