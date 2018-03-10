using PathFiender.Types;
using System.Collections.Generic;

namespace PathFiender.Commands
{
    public interface ISearchCommand
    {
        IReadOnlyCollection<Node> FindWay();
    }
}
