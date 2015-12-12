using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
class Solution {
    private static int treeSize;
    private static int truncatedEdges = 0;
    
    static void Main(String[] args) {
        var input = Console.ReadLine().Split(' ');
        
        var n = int.Parse(input[0]);
        var m = int.Parse(input[1]);
        
        treeSize = n;
        int[][] adjMatrix = new int[n][];
        for (int x = 0; x < n; x++) {
            adjMatrix[x] = new int[n];
        }
        
        bool[] visited = new bool[n];
        
        int edge1, edge2;
        for (int i = 0; i < m; i++) {
            var line = Console.ReadLine().Split(' ');
            edge1 = int.Parse(line[0]) - 1;
            edge2 = int.Parse(line[1]) - 1;
            
            adjMatrix[edge1][edge2] = 1;
            adjMatrix[edge2][edge1] = 1;
        }
        
        GetSize(adjMatrix, visited, 0);
        
        Console.WriteLine(truncatedEdges);
    }
    
    private static int GetSize(int[][] adjMatrix, bool[] visited, int vertex) {
        visited[vertex] = true;
        int vertexSize = 1;
        for (int i = 0; i < adjMatrix.Length; i++) {
            if (adjMatrix[vertex][i] == 1 && !visited[i]) {
                int size = GetSize(adjMatrix, visited, i);
                vertexSize += size;
                
                if (size % 2 == 0) {
                    if ((treeSize - size) % 2 == 0) {
                        truncatedEdges++;
                        treeSize -= size;
                        vertexSize -= size;
                    }
                }
            }
        }
        
        visited[vertex] = false;
        return vertexSize;
    }
}