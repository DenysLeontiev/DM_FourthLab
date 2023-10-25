using DM_FourthLab.DataClasses;
using System;
using System.Collections.Generic;

namespace DM_FourthLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of vertices:");
            int numberOfVertices = int.Parse(Console.ReadLine());

            Graph graph = new Graph(numberOfVertices);

            Console.WriteLine("Enter the edges in such patetrn (0 1) => edge from 0 to 1 separated with space.if input is empty, it stops");
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                string[] edge = input.Split(' ');
                int u = int.Parse(edge[0]);
                int v = int.Parse(edge[1]);
                graph.addEdge(u, v);
            }

            Console.WriteLine("Enter the source node:");
            int source = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the destination node:");
            int destination = int.Parse(Console.ReadLine());

            List<List<int>> allPaths = graph.findAllPaths(source, destination);

            Console.WriteLine("All Paths from " + source + " to " + destination + ":");
            foreach (List<int> path in allPaths)
            {
                Console.WriteLine(string.Join(" -> ", path));
            }

            //Graph graph = new Graph(3);
            //graph.addEdge(0, 1);
            //graph.addEdge(1, 2);
            //graph.addEdge(0, 2);

            //int source = 0;
            //int destination = 2;

            //List<List<int>> allPaths = graph.findAllPaths(source, destination);

            //Console.WriteLine("All paths from {0} to {1}:", source, destination);
            //foreach (var path in allPaths)
            //{
            //    Console.WriteLine(string.Join(" -> ", path));
            //}
        }
    }
}
