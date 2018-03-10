using PathFiender.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathFiender
{
    internal class ConsolePrinter: IPrinter
    {
        public void PrintMap(string[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0}  ", arr[i, j]);
                Console.WriteLine();
            }
        }

        public void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public void PrintStatistic(float seconds, int pathLength, int count, string name)
        {
            Console.Write("seconds: {0}\nlength: {1}\ncount: {2}\nname: {3}", seconds, pathLength, count, name);
        }

        public void PrintMapAndPath(IReadOnlyCollection<Node> ListOfNodes, string[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (ListOfNodes.Where(x => x.X == i && x.Y == j).FirstOrDefault() != null)
                        map[i, j] = "@";
                }
            }
            this.PrintMap(map);
        }
    }
}
