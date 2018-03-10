using PathFiender.Types;

namespace PathFiender.Maps
{
    internal class Jump : NeighborValidator
    {

        protected Node End;

        public Node JumpWay { get; private set; }

        public Jump(Node[,] nodes, Node end) : base(nodes)
        {
            this.End = end;
        }

        public Node JumpNode(Node nA, Node nB) {
            if (!base.IsAccessible(nA.X, nA.Y))
                return null;

            if (nA == this.End)
            {
                return nA;
            }
            var deltaX = nA.X - nB.X;
            var deltaY = nA.Y - nB.Y;

            if (deltaX != 0) {
                if ((base.IsAccessible(nA.X, nA.Y -1) &&  !base.IsAccessible(nA.X - deltaX, nA.Y - 1)) ||
                    (base.IsAccessible(nA.X, nA.Y + 1) && !base.IsAccessible(nA.X - deltaX, nA.Y + 1)))
                {
                    return nA;
                }
            }
            else if (deltaY != 0)
            {
                if ((base.IsAccessible(nA.X - 1, nA.Y) && !base.IsAccessible(nA.X - 1, nA.Y - deltaY)) ||
                    (base.IsAccessible(nA.X + 1, nA.Y) && !base.IsAccessible(nA.X + 1, nA.Y - deltaY)))
                {
                    return nA;
                }

                if ((this.JumpNode(new Node(nA.X + 1, nA.Y, nA.Floor), nA) != null) &&
                    (this.JumpNode(new Node(nA.X - 1, nA.Y, nA.Floor), nA) != null))
                {
                    return nA;
                }

            }
            return JumpNode(new Node(nA.X + deltaX, nA.Y + deltaY, nA.Floor), nA);

        }

    }
}
