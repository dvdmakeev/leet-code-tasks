public class Solution 
{
    public bool ValidPath(int n, int[][] edges, int start, int end) 
    {
        Dictionary<int, List<int>> graph = CreateGraph(edges, n);
        
        var queue = new Queue<int>();
        var visited = new HashSet<int>();
        
        queue.Enqueue(start);
        while (queue.Count > 0)
        {
            var currentVertex = queue.Dequeue();
            if (currentVertex == end)
            {
                return true;
            }
            
            visited.Add(currentVertex);
            
            foreach (var neighbour in graph[currentVertex])
            {       
                if (!visited.Contains(neighbour))
                {
                    queue.Enqueue(neighbour);
                }
            }
        }
        
        return false;
    }
    
    private Dictionary<int, List<int>> CreateGraph(int[][] edges, int n)
    {
        var graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; ++i)
        {
            graph[i] = new List<int>();
        }
        
        for (int i = 0; i < edges.Length; ++i)
        {
            if (!graph.ContainsKey(edges[i][0]))
            {
                graph[edges[i][0]] = new List<int>();
            }
            
            graph[edges[i][0]].Add(edges[i][1]);
            
            if (!graph.ContainsKey(edges[i][1]))
            {
                graph[edges[i][1]] = new List<int>();
            }
            
            graph[edges[i][1]].Add(edges[i][0]);
        }
        
        return graph;
    }
}