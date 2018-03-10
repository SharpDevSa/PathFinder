using System.Collections.Generic;
using System.Linq;
using PathFiender.Types;

namespace PathFiender.Paths
{
    internal sealed class SequentialPathBuilder : PathBuilder
    {

        public SequentialPathBuilder(Node end) : base(end)
        {
            
        }

        

        public override IReadOnlyCollection<Node> GetPath()
        {
            Stack<Node> nodeList = new Stack<Node>();
            if (End == null) return nodeList;
            var end = End;
            while (end.Parrent != null)
            {
                end = end.Parrent;
                nodeList.Push(end);
            }
            nodeList.Reverse();
            return nodeList;
        }
    }
}
