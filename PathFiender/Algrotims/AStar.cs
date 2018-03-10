using System.Collections.Generic;
using System.Diagnostics;
using Priority_Queue;
using PathFiender.Maps;
using PathFiender.Types;
using PathFiender.Paths;

namespace PathFiender.Algrotims
{
    internal class AStar : BestFirstSearch
    {
        public Dictionary<Node, Node> cameFrom
        = new Dictionary<Node, Node>();
        public Dictionary<Node, float> costSoFar
            = new Dictionary<Node, float>();

        public AStar(Map map, IPrinter printer) : base(map, printer){}

        public override string ToString()
        {
            return "A*";
        }

        internal override PathBuilder GetPath(Node start, Node end)
        {
            int operationCount = 0;
            Stopwatch sp = new Stopwatch();
            var qNodes = new SimplePriorityQueue<Node>();
            qNodes.Enqueue(start, 0);
            cameFrom[start] = start;
            costSoFar[start] = 0;
            sp.Start();

            while (qNodes.Count > 0)
            {
                operationCount++;
                var current = qNodes.Dequeue();

                
                if (Animation)
                {
                    System.Threading.Thread.Sleep(10);
                    PrintMap();
                }

                foreach (var neighbor in this.World.GetNeighbors(base.finder, current))
                {
                    //1 it's a cost for next step
                    var newCost = costSoFar[current] + 1;
                    if (!costSoFar.ContainsKey(neighbor)
                    || newCost < costSoFar[neighbor])
                    {
                        if (costSoFar.ContainsKey(neighbor))
                            costSoFar.Remove(neighbor);
                        costSoFar.Add(neighbor, newCost);
                        float priority = newCost + base.Heuristic(neighbor, end);
                        neighbor.Parrent = current;
                        qNodes.Enqueue(neighbor, priority);
                        cameFrom[neighbor] = current;

                        if (neighbor == end)
                        {
                            var sb = new SequentialPathBuilder(neighbor);
                            return this.End(sp, operationCount, sb);
                        }
                        this.World.SetVisited(current);

                    }
                }

            }
            return this.End(sp, operationCount, new SequentialPathBuilder(null));
        }
    }
}
