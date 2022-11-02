public class Solution 
{
    private List<string> GetMutations(string gen, string[] bank)
    {
        var mutations = new List<string>();
        foreach (string current in bank)
        {
            bool correct = false;
            for (int i = 0; i < gen.Length; ++i)
            {
                if (gen[i] != current[i])
                {
                    if (!correct)
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false;
                        break;
                    }
                }
            }
            
            if (correct)
            {
                mutations.Add(current);
            }
        }
        
        return mutations;
    }
    
    public int MinMutation(string start, string end, string[] bank) 
    {
        var queue = new Queue<string>();
        queue.Enqueue(start);
        var visited = new HashSet<string>();        
        
        int distance = 0;        
        while (queue.Count > 0)
        {
            int queueSize = queue.Count;
            ++distance;
            
            for (int i = 0; i < queueSize; ++i)
            {
                string current = queue.Dequeue();
                visited.Add(current);

                var mutations = GetMutations(current, bank);
                foreach (string mutation in mutations)
                {
                    if (end.Equals(mutation))
                    {
                        return distance;
                    }

                    if (!visited.Contains(mutation))
                    {
                        queue.Enqueue(mutation);
                    }
                }
            }
        }
        
        return -1;
    }
}
