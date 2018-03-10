using System.Collections.Generic;
using System.Diagnostics;
using PathFiender.Maps;
using PathFiender.Types;
using PathFiender.Paths;

namespace PathFiender.Algrotims
{
    class BreadthFirstSearch : BaseMapAnalizer
    {
        public BreadthFirstSearch(Map map, IPrinter printer) : base(map, printer)
        {

        }

        internal override BaseNeighborFinder GetFinder()
        {
            return new FinderA(base.World.GetNodes());
        }

        public override string ToString()
        {
            return "Breadth First";
        }

        internal override PathBuilder GetPath(Node start, Node end)
        {
            int operationCount = 0;
            Stopwatch sp = new Stopwatch();
            var qNodes = new Queue<Node>();
            var visited = new HashSet<Node>();
            qNodes.Enqueue(start);
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
                    if (!visited.Contains(neighbor))
                    {
                        neighbor.Parrent = current;
                        qNodes.Enqueue(neighbor);
                    }
                    if (neighbor == end) {
                        var sb = new SequentialPathBuilder(neighbor);
                        return this.End(sp, operationCount, sb);
                    }

                    this.World.SetVisited(current);

                }
            }
            return this.End(sp, operationCount, new SequentialPathBuilder(null));
        }
    }
}
