using PathFiender.Maps;
using System;
using System.Diagnostics;
using PathFiender.Types;
using PathFiender.Paths;

namespace PathFiender.Algrotims
{
    internal abstract class BaseMapAnalizer
    {
        #region Protected fields
        protected BaseNeighborFinder finder;
        protected readonly Map World;
        #endregion
        #region Public property
        public IPrinter Printer { get; private set; }
        public bool Animation { get; set; }
        #endregion

        public BaseMapAnalizer(Map map, IPrinter printer) {
            this.World = map.GetVerginMap();
            this.Printer = printer;
            this.finder = GetFinder();
        }

        

        public void PrintMap()
        {
            this.Printer.PrintMap(this.World.NodeToView());
        }

        protected PathBuilder End(Stopwatch sp, int operations, PathBuilder pathBilder) {
            sp.Stop();
            PrintMap();
            var stackPath = pathBilder.GetPath();
            if (Animation == true)
            {
                this.Printer.PrintStatistic(sp.ElapsedMilliseconds, stackPath.Count, operations, this.ToString());
                Console.ReadKey();
                this.Printer.PrintMapAndPath(stackPath, this.World.NodeToView());
                Console.ReadKey();
            }
            return pathBilder;
        }
        #region Abstract methods
        internal abstract BaseNeighborFinder GetFinder();
        internal abstract PathBuilder GetPath(Node start, Node end);
        #endregion
    }
}
