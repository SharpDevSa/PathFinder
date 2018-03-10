using PathFiender.Maps;
using PathFiender.Paths;
using PathFiender.Types;
using Priority_Queue;
using System.Collections.Generic;
using System.Diagnostics;

namespace PathFiender.Algrotims
{
    class JumpPointSearch : AStar
    {
        public HashSet<Node> OpenList = new HashSet<Node>();
        
        public JumpPointSearch(Map map, IPrinter printer) : base(map, printer)
        {
        }

        public override string ToString()
        {
            return "Jump point";
        }

        internal override BaseNeighborFinder GetFinder()
        {
            return new NeighborJumpFinder(this.World.GetNodes());
        }

        internal override PathBuilder GetPath(Node start, Node end)
        {
            int operationCount = 0;
            var qNodes = new SimplePriorityQueue<Node>();
            var jumper = new Jump(base.World.GetNodes(), end);
            Stopwatch sp = new Stopwatch();
            qNodes.Enqueue(start, 0);
            cameFrom[start] = start;
            costSoFar[start] = 0;
            sp.Start();

            while (qNodes.Count > 0) {
                operationCount++;
                var current = qNodes.Dequeue();

                

                if (Animation)
                {
                    System.Threading.Thread.Sleep(10);
                    PrintMap();
                }

                foreach (var neighbor in base.World.GetNeighbors(base.finder, current))
                {
                    var jumpNode = jumper.JumpNode(neighbor, current);
                    if (jumpNode != null)
                    {
                        float newCost = current.Cost + base.Heuristic(jumpNode, end);
                        if (!OpenList.Contains(jumpNode))
                        {
                            OpenList.Add(jumpNode);
                            jumpNode.Parrent = current;
                            jumpNode.Cost = newCost;
                            qNodes.Enqueue(jumpNode, newCost);
                            cameFrom[jumpNode] = current;
                            this.World.SetVisited(jumpNode);
                            if (jumpNode == end)
                            {
                                var jumpPath = new JumpPathBuilder(jumpNode, start);
                                return this.End(sp, operationCount, jumpPath);
                            }
                        }  
                    }
                }
            }
            return this.End(sp, operationCount, new JumpPathBuilder(null, start));
        }
    }
}
