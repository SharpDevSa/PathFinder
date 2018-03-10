using PathFiender.Types;
using System.Collections.Generic;

namespace PathFiender.Commands
{
    public class AdaptiveRouting
    {
        private Dictionary<int, ISearchCommand> Commands;

        public AdaptiveRouting() {
            this.Commands = new Dictionary<int, ISearchCommand>();
        }

        public void SetCommand(int key, ISearchCommand command)
        {
            this.Commands.Add(key, command);
        }

        public IReadOnlyCollection<Node> StartCommand(int key)
        {
            return this.Commands[key].FindWay();
        }

        
    }
}
