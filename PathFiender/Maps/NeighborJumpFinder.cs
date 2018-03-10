using System;
using System.Collections.Generic;
using PathFiender.Types;

namespace PathFiender.Maps
{
    class NeighborJumpFinder : FinderA
    {
        public NeighborJumpFinder(Node[,] nodes) : base(nodes)
        {
        }

        public override Node[] GetNeighbor(Node node)
        {
            if (node.Parrent == null)
                return base.GetNeighbor(node);

            List<Node> neighbors = new List<Node>();
            var parrent = node.Parrent;
            var deltaX = (node.X - parrent.X) / Math.Max(Math.Abs(node.X - parrent.X), 1);
            var deltaY = (node.Y - parrent.Y) / Math.Max(Math.Abs(node.Y - parrent.Y), 1);


           
            if (deltaX != 0)
            {
                if (base.IsAccessible(node.X, node.Y - 1))
                {
                    neighbors.Add(base.Nodes[node.X, node.Y - 1]);
                }
                if (base.IsAccessible(node.X, node.Y + 1))
                {
                    neighbors.Add(base.Nodes[node.X, node.Y + 1]);
                }
                if (base.IsAccessible(node.X + deltaX, node.Y))
                {
                    neighbors.Add(base.Nodes[node.X + deltaX, node.Y]);
                }
            }
            else if (deltaY != 0) {
                if (base.IsAccessible(node.X-1, node.Y))
                {
                    neighbors.Add(base.Nodes[node.X - 1, node.Y]);
                }
                if (base.IsAccessible(node.X + 1, node.Y))
                {
                    neighbors.Add(base.Nodes[node.X + 1, node.Y]);
                }
                if (base.IsAccessible(node.X, node.Y + deltaY))
                {
                    neighbors.Add(base.Nodes[node.X, node.Y + deltaY]);
                }
            }
            
            return neighbors.ToArray();
            
        }
    }
}
