using PathFiender.Types;

namespace PathFiender
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Press any key to next animation
            //set animation false for disable
            Node EndPosition = new Node(7, 5);
            PathMapBuilder builder = new PathMapBuilder(EndPosition, true);
            builder.Execute(
                PathMapBuilder.Searcher.AStar | 
                PathMapBuilder.Searcher.BestFirstSearch |
                PathMapBuilder.Searcher.BreadhFirsSearch | 
                PathMapBuilder.Searcher.JumpPointSearch);
        }
    }
}
