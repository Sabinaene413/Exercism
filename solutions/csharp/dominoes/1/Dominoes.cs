public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var list = dominoes.ToList();
        
        if (list.Count == 0) return true;

        var adj = new Dictionary<int, List<int>>();
        var degree = new Dictionary<int, int>();

        foreach (var (u, v) in list)
        {
            if (!adj.ContainsKey(u)) adj[u] = new List<int>();
            if (!adj.ContainsKey(v)) adj[v] = new List<int>();
            
            adj[u].Add(v);
            adj[v].Add(u);

            degree[u] = degree.GetValueOrDefault(u) + 1;
            degree[v] = degree.GetValueOrDefault(v) + 1;
        }


        if (degree.Values.Any(d => d % 2 != 0)) return false;

        var firstNode = list[0].Item1;
        var visited = new HashSet<int>();
        var queue = new Queue<int>();

        queue.Enqueue(firstNode);
        visited.Add(firstNode);

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            foreach (var neighbor in adj[curr])
            {
                if (visited.Add(neighbor))
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        return visited.Count == adj.Keys.Count;
    }
}