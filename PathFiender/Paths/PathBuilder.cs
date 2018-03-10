using System.Collections.Generic;
using PathFiender.Types;

namespace PathFiender.Paths
{
    internal abstract class PathBuilder
    {
        protected readonly Node End;

        public PathBuilder( Node end)
        {
            End = end;
        }
        public abstract IReadOnlyCollection<Node> GetPath();
    }
}
