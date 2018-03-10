using System.Collections.Generic;
using System.Linq;
using PathFiender.Types;

namespace PathFiender.Paths
{
    class JumpPathBuilder : PathBuilder
    {
        public IPrinter Printer { get; set; }
        protected readonly Node Start;
        
        public JumpPathBuilder(Node end, Node start) : base(end)
        {
            this.Start = start;
        }

        public override IReadOnlyCollection<Node> GetPath()
        {
            Stack<Node> nodeList = new Stack<Node>();
            if (End == null) return nodeList;
            var end = End;
            while (end.Parrent != null)
            {
                if (IsNeighbourhood(end, end.Parrent))
                {
                    end = end.Parrent;
                    nodeList.Push(end);
                }
                else
                {
                    end = FindLostWay(end);
                    end = end.Parrent;
                    nodeList.Push(end);
                }
            }
            nodeList.Reverse();
            return nodeList;
        }


        private Node FindLostWay(Node node) {

            var parrent = node.Parrent;
            int deltaX =  node.X - parrent.X;
            int deltaY = node.Y - parrent.Y;
            int iteration = 0;
            bool goUp = deltaY < 0;
            bool goLeft = deltaX < 0;

            if (deltaX != 0)
            {
                iteration = goLeft ? 1 : -1;
                node.Parrent = new Node(node.X + iteration, node.Y);
                node.Parrent.Parrent = parrent;
            }
            else if (deltaY != 0)
            {
                iteration = goUp ? 1 : -1;
                node.Parrent = new Node(node.X, node.Y + iteration);
                node.Parrent.Parrent = parrent;
            }

            return node;
        }


        private bool IsNeighbourhood(Node nd1, Node nd2) {
            if (nd1.X - 1 == nd2.X || nd1.X + 1 == nd2.X) return true;
            else if (nd1.Y - 1 == nd2.Y || nd1.Y + 1 == nd2.Y) return true;
            else return false;
        }

    }
}
