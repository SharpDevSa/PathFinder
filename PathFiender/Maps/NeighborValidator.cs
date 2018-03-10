using PathFiender.Types;

namespace PathFiender.Maps
{
    internal class NeighborValidator
    {
        private int Width { get { return Nodes.GetLength(1); } }
        private int Height { get { return Nodes.GetLength(0); } }

        protected Node[,] Nodes;

        public NeighborValidator(Node[,] nodes) {
            this.Nodes = nodes;
        }

        public bool IsInTheWorld(int x, int y)
        {
            return (x >= 0 && x < this.Height) && (y >= 0 && y < this.Width);
        }

        public bool IsAccessible(int x, int y)
        {
            return IsInTheWorld(x, y) && this.Nodes[x, y].Floor;
        }

    }
}
