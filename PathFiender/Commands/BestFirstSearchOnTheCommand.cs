using System.Collections.Generic;
using PathFiender.Types;
using PathFiender.Algrotims;

namespace PathFiender.Commands
{
    internal class BestFirstSearchOnTheCommand : ISearchCommand, IsValidCommandParametr
    {
        private BaseMapAnalizer MapAnalizer;
        private Node Start;
        private Node End;

        public BestFirstSearchOnTheCommand(BestFirstSearch search, Node start, Node end) {
            Start = start;
            End = end;
            MapAnalizer = search;
        }

        public IReadOnlyCollection<Node> FindWay()
        {
            if (!this.IsValid()) throw new WrongPointException();
            var way = MapAnalizer.GetPath(Start, End);
            var pathCollection = way.GetPath();
            return pathCollection;
        }

        public bool IsValid()
        {
            return (MapAnalizer.GetFinder().IsAccessible(End.X, End.Y) && MapAnalizer.GetFinder().IsAccessible(Start.X, Start.Y));
        }
    }
}
