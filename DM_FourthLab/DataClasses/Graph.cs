using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_FourthLab.DataClasses
{
    public class Graph
    {
        private List<int>[] adjacent; // суміжні вершини для певної вершини
        private List<List<int>> allPaths; // знайдені вершини

        public Graph(int v)
        {
            adjacent = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adjacent[i] = new List<int>();
        }

        public void addEdge(int v, int w)
        {
            adjacent[v].Add(w);
        }

        // Метод для знаходження та виведення всіх шляхів між вершинами 's' та 'd'
        public List<List<int>> findAllPaths(int s, int d)
        {
            allPaths = new List<List<int>>();
            List<int> path = new List<int>();
            path.Add(s); // Додаємо початкову вершину в поточний шлях
            findAllPathsUtil(s, d, path);
            return allPaths;
        }

        private void findAllPathsUtil(int u, int d, List<int> path)
        {
            // Якщо поточна вершина дорівнює цільовій вершині (знайдено шлях)
            if (u == d)
            {
                allPaths.Add(new List<int>(path));
                return;
            }

            // Рекурсивно перебираємо всі сусідні вершини
            foreach (int i in adjacent[u])
            {
                if (!path.Contains(i)) // Якщо вершина 'i' ще не була включена до поточного шляху
                {
                    path.Add(i); // Додаємо вершину 'i' до поточного шляху
                    findAllPathsUtil(i, d, path); // Рекурсивно продовжуємо пошук
                    path.Remove(i); // Після завершення рекурсивного виклику видаляємо вершину 'i' з поточного шляху
                }
            }
        }
    }
}
