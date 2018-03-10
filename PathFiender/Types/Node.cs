using System.Collections.Generic;

namespace PathFiender.Types
{
    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Floor { get; set; }
        public bool Visited { get; set; }
        public Node Parrent { get; set; }
        public List<Node> Path { get; set; }

        public float Cost;

        public Node(int x, int y, bool floor = true, bool visited = false) {
            this.X = x;
            this.Y = y;
            this.Floor = floor;
            this.Visited = visited;
            this.Path = new List<Node>();
        }
        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.X, this.Y);
        }

        public override bool Equals(object obj)
        {
            if (obj is Node) {
                var node = obj as Node;
                return (X == node.X && Y == node.Y);
            }
            return false; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Node c1, Node c2)
        {
            if (object.ReferenceEquals(c1, null))
            {
                return object.ReferenceEquals(c2, null);
            }
            return c1.Equals(c2);
        }

        public static bool operator !=(Node c1, Node c2)
        {
            if (object.ReferenceEquals(c1, null))
            {
                return !object.ReferenceEquals(c2, null);
            }
            return !c1.Equals(c2);
        }
    }
}
