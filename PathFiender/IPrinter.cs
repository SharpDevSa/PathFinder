using PathFiender.Types;
using System.Collections.Generic;

namespace PathFiender
{
    internal interface IPrinter
    {
        void PrintMap(string[,] arr);
        void PrintName(string name);
        void PrintStatistic(float seconds, int pathLength, int count, string name);
        void PrintMapAndPath(IReadOnlyCollection<Node> ListOfNodes, string[,] map);
    }
}
