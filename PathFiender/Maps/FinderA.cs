using System.Collections.Generic;
using PathFiender.Types;

namespace PathFiender.Maps
{
    internal class FinderA : BaseNeighborFinder
    {
        public FinderA(Node[,] nodes) : base(nodes)
        {
        }

        public override Node[] GetNeighbor(Node node)
        {
            List<Node> childs = new List<Node>();
            if (base.IsAccessible(node.X + 1, node.Y)) childs.Add(base.Nodes[node.X + 1, node.Y]);
            if (base.IsAccessible(node.X - 1, node.Y)) childs.Add(base.Nodes[node.X - 1, node.Y]);
            if (base.IsAccessible(node.X, node.Y + 1)) childs.Add(base.Nodes[node.X, node.Y + 1]);
            if (base.IsAccessible(node.X, node.Y - 1)) childs.Add(base.Nodes[node.X, node.Y - 1]);
            return childs.ToArray();
        }
    }
}
