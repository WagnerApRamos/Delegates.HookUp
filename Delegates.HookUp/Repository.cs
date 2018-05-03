using System.Collections.Generic;
using System.Linq;

namespace Delegates.HookUp
{
    public class Repository
    {
        private int _serverCount;

        public Repository(int serverCount)
        {
            _serverCount = serverCount;
        }

        public IEnumerable<Server> GetServers()
        {
            foreach (var number in Enumerable.Range(0, _serverCount))
            {
                yield return new Server($"Srv{number + 1}", $"Server Nro {number}");
            }
        }
    }
}
