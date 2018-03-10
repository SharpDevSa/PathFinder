using PathFiender.Maps;
using PathFiender.Types;
using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using PathFiender.Paths;

namespace PathFiender.Algrotims
{
    class BestFirstSearch : BaseMapAnalizer
    {
        public BestFirstSearch(Map map, IPrinter printer) : base(map, printer)
        {
        }

        internal override BaseNeighborFinder GetFinder()
        {
            return new FinderA(base.World.GetNodes());
        }

        protected int Heuristic(Node one, Node two)
        {
            return Math.Abs(one.X - two.X) + Math.Abs(one.Y + two.Y);
        }

        public override string ToString()
        {
            return "Best First";
        }

        internal override PathBuilder GetPath(Node start, Node end)
        {
            int operationCount = 0;
            Stopwatch sp = new Stopwatch();
            var qNodes = new SimplePriorityQueue<Node>();
            var visited = new HashSet<Node>();

            qNodes.Enqueue(start, 0);

            sp.Start();

            while (qNodes.Count > 0)
            {
                operationCount++;
                var current = qNodes.Dequeue();
                if (visited.Contains(current))
                    continue;

                if (Animation)
                {
                    System.Threading.Thread.Sleep(10);
                    PrintMap();
                }

                visited.Add(current);
                foreach (var neighbor in this.World.GetNeighbors(base.finder, current))
                {
                    if (visited.Contains(neighbor)) continue;
                    int priority = this.Heuristic(end, neighbor);
                    neighbor.Parrent = current;
                    qNodes.Enqueue(neighbor, priority);

                    if (neighbor == end) {

                        var sb = new SequentialPathBuilder(neighbor);
                        return this.End(sp, operationCount,sb);
                    }

                    this.World.SetVisited(current);
                }
            }
            return End(sp, operationCount, new SequentialPathBuilder(null));
        }
    }
}
