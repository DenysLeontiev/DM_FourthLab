using DM_FourthLab.DataClasses;
using System;
using System.Collections.Generic;

namespace DM_FourthLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(0, 3);
            graph.addEdge(1, 3);
            graph.addEdge(2, 3);
            graph.addEdge(1, 4);
            graph.addEdge(2, 4);

            int source = 0;
            int destination = 3;

            List<List<int>> allPaths = graph.findAllPaths(source, destination);

            Console.WriteLine("All paths from {0} to {1}:", source, destination);
            foreach (var path in allPaths)
            {
                Console.WriteLine(string.Join(" -> ", path));
            }
        }
    }
}
