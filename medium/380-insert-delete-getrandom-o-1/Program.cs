/*
    1 5 3 6 4
    remove 3
    1 5 6 4
    getRandom() -> rand(1, 4)

    array    [1, 5, 3, 6, 4]

    counter = 4
    hashset: {1: 0, 5: 1, 3: 2, 6: 3, 4: 4}

    getRandom(): 
        array[rand(0, counter)]

    insert(val): 
        hashset[val]   = ++counter
        array[counter] = val

    remove(val):
        i = hashse[val]
        hashset.remove(val)

        array[i] = array[counter]
        hashset[array[i]] = i
        --counter
*/
public class RandomizedSet 
{
    private Random rand;

    private List<int> set;
    private Dictionary<int, int> indexMap;
    

    public RandomizedSet() 
    {
        rand = new Random();

        set = new List<int>();
        indexMap = new Dictionary<int, int>();
    }
    
    public bool Insert(int val) 
    {
        if (indexMap.ContainsKey(val))
        {
            return false;
        }

        set.Add(val);
        indexMap[val] = set.Count - 1;

        return true;
    }
    
    public bool Remove(int val) 
    {
        if (!indexMap.ContainsKey(val))
        {
            return false;
        }

        int lastElement = set[set.Count - 1];
        int i = indexMap[val];

        set[i] = lastElement;
        indexMap[lastElement] = i;

        set.RemoveAt(set.Count - 1);
        indexMap.Remove(val);

        return true;
    }
    
    public int GetRandom() 
    {
        return set[rand.Next(set.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
