using PathFiender.Algrotims;
using PathFiender.Types;

namespace PathFiender.Maps
{
    internal abstract class BaseNeighborFinder : NeighborValidator
    {
        public BaseNeighborFinder(Node[,] nodes) : base(nodes)
        {
        }
        public abstract Node[] GetNeighbor(Node node);
    }
}
