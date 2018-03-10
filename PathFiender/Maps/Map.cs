using PathFiender.Types;

namespace PathFiender.Maps
{
    internal class Map
    {
        private int Width {get{ return Nodes.GetLength(1); } }
        private int Height { get {  return Nodes.GetLength(0); } }

        private Node[,] Nodes;

        public static Map GetMapWithNodes(int[,] map){
            int width = map.GetLength(1);
            int height = map.GetLength(0);
            Node[,] nodeMap = new Node[height, width];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width ; j++)
                    nodeMap[i,j] = new Node(i, j, map[i, j] == 0 ? true : false);
            return new Map(nodeMap);
        }

        public string[,] NodeToView() {
            string[,] vMap = new string[Height, Width];
            for (int i = 0; i < Height; i++) {
                for (int j = 0; j < Width; j++)
                    if (this.GetNode(i, j).Visited)
                        vMap[i, j] = "*";
                    else if (!this.GetNode(i, j).Floor)
                        vMap[i, j] = "#";
                    else
                        vMap[i, j] = " ";
            }
            return vMap;
        }
        public Map(Node[,] nodes) {
            this.Nodes = nodes;
        }

        public Map GetVerginMap()
        {
            for (int i = 0; i < this.Height; i++)
                for (int j = 0; j < this.Width; j++)
                {
                    this.Nodes[i, j].Visited = false;
                    this.Nodes[i, j].Parrent = null;
                }
            return new Map(this.Nodes);
        }

        public Node[,] GetNodes()
        {
            return this.Nodes;
        }

        public Node GetNode(int x, int y){
           return this.Nodes[x, y];
        }

        public void SetVisited(Node node) {
            this.Nodes[node.X, node.Y].Visited = true;
        }

        public Node[] GetNeighbors(BaseNeighborFinder finder, Node parrentNode) {
            return finder.GetNeighbor(parrentNode);
        }


    }
}
