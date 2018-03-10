using PathFiender.Commands;
using PathFiender.Maps;
using PathFiender.Types;
using System.Collections.Generic;

namespace PathFiender
{
    public sealed class PathMapBuilder
    {
        #region Private fields
        private int[,] InputMap =
        {
            {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            {-1, 0,-1, 0, 0, 0,-1, 0, 0,-1},
            {-1, 0, 0, 0,-1, 0,-1,-1, 0,-1},
            {-1,-1,-1, 0,-1, 0, 0, 0, 0,-1},
            {-1, 0, 0, 0, 0, 0,-1,-1, 0,-1},
            {-1, 0,-1,-1,-1, 0,-1, 0, 0,-1},
            {-1, 0, 0,-1,-1, 0,-1,-1, 0,-1},
            {-1,-1, 0,-1, 0, 0, 0,-1, 0,-1},
            {-1, 0, 0, 0, 0,-1, 0, 0, 0,-1},
            {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}

        };

        AdaptiveRouting Routing;
        private Node StartPosition;
        private Node EndPosition;
        private IPrinter Printer;
        private bool Animation;
        Map World;
        #endregion
        #region Public field
        public enum Searcher: int {
            AStar = 0,
            BestFirstSearch = 1,
            BreadhFirsSearch = 2,
            JumpPointSearch = 3
        }
        #endregion

        public PathMapBuilder(Node endPosition, bool animation)
        {
            this.StartPosition = new Node(1, 1);
            this.EndPosition = endPosition;
            this.Printer = new ConsolePrinter();
            this.Animation = animation;
            this.World = Map.GetMapWithNodes(InputMap);
            Routing = new AdaptiveRouting();
            Routing.SetCommand(
                (int)Searcher.AStar, 
                new AStarOnTheCommand(new Algrotims.AStar(this.World, this.Printer)
                { Animation = this.Animation }, 
                this.StartPosition, 
                endPosition));
            Routing.SetCommand(
                (int)Searcher.BestFirstSearch, 
                new BestFirstSearchOnTheCommand(new Algrotims.BestFirstSearch(this.World, this.Printer)
                { Animation = this.Animation }, 
                this.StartPosition, 
                endPosition));
            Routing.SetCommand(
                (int)Searcher.BreadhFirsSearch, 
                new BreadthFirstSearchOnTheCommand(new Algrotims.BreadthFirstSearch(this.World, this.Printer)
                { Animation = this.Animation }, 
                this.StartPosition, 
                endPosition));
            Routing.SetCommand(
                (int)Searcher.JumpPointSearch, 
                new JumpPointSearchOnTheCommand(new Algrotims.JumpPointSearch(this.World, this.Printer)
                { Animation = this.Animation }, 
                this.StartPosition, endPosition));
        }

        public Dictionary<Searcher, IReadOnlyCollection<Node>> Execute(Searcher executeType) {

            var ExecutedSerachers = new Dictionary<Searcher, IReadOnlyCollection<Node>>();
            if (executeType.HasFlag(Searcher.AStar))
            {
               var resultPath = Routing.StartCommand((int)Searcher.AStar);
               ExecutedSerachers.Add(Searcher.AStar, resultPath);
            }
            if (executeType.HasFlag(Searcher.BestFirstSearch)) {
                var resultPath = Routing.StartCommand((int)Searcher.BestFirstSearch);
                ExecutedSerachers.Add(Searcher.BestFirstSearch, resultPath);
            }
            if (executeType.HasFlag(Searcher.BreadhFirsSearch)) {
                var resultPath = Routing.StartCommand((int)Searcher.BreadhFirsSearch);
                ExecutedSerachers.Add(Searcher.BreadhFirsSearch, resultPath);
            }
            if (executeType.HasFlag(Searcher.JumpPointSearch)) {
                var resultPath = Routing.StartCommand((int)Searcher.JumpPointSearch);
                ExecutedSerachers.Add(Searcher.JumpPointSearch, resultPath);
            }
            return ExecutedSerachers;
        }
        
    }
}
