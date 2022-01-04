public class Solution 
{
    public class Heap
    {
        private int heapSize;
        private int[] heap;
        
        public Heap(int[] source)
        {
            heapSize = source.Length;
            heap = source;
            
            BuildHeap();
        }
        
        private void BuildHeap()
        {
            for (int i = heapSize / 2; i >= 0; --i)
            {
                HeapifyDown(i);
            }
        }
        
        private void HeapifyDown(int i)
        {
            while (i < heapSize - 1)
            {
                int left = Left(i);
                int right = Right(i);
                int candidate = i;
                if (left < heapSize && heap[left] < heap[i])
                {
                    candidate = left;
                }
                if (right < heapSize && heap[right] < heap[candidate])
                {
                    candidate = right;
                }
                if (candidate == i)
                {
                    break;
                }
                else
                {
                    Swap(i, candidate);
                    i = candidate;
                }
            }
            
        }
        
        private void HeapifyUp(int i)
        {
            while (i > 0)
            {
                int parent = Parent(i);
                if (heap[parent] > heap[i])
                {
                    Swap(i, parent);
                    i = parent;
                }
                else
                {
                    break;
                }
                
            }
        }
        
        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
        
        private int Parent(int i)
        {
            return (i - 1) / 2;
        }
        
        private int Left(int i)
        {
            return 2 * i + 1;
        }
        
        private int Right(int i)
        {
            return 2 * i + 2;
        }
        
        public void Insert(int key)
        {
            ++heapSize;
            heap[heapSize - 1] = key;
            HeapifyUp(heapSize - 1);
        }
        
        public int ExtractMin()
        {
            int min = heap[0];
            heap[0] = heap[heapSize - 1];
            --heapSize;
            HeapifyDown(0);
            
            return min;
        }
        
        public int Count()
        {
            return heapSize;
        }
    }
    
    public int ConnectSticks(int[] sticks) 
    {
        if (sticks.Length < 2)
        {
            return 0;
        }
        
        var heap = new Heap(sticks);
        int cost = 0;
        while (heap.Count() > 1)
        {
            int a = heap.ExtractMin();
            int b = heap.ExtractMin();
            int c = a + b;
            cost += c;
            heap.Insert(c);
        }
        
        return cost;
    }
}