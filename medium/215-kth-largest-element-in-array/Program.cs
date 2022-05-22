public class Solution 
{
    public class Heap
    {
        private int heapSize;
        private int[] heap;
        
        public Heap(int[] array)
        {
            heapSize = array.Length;
            heap = array;
            BuildHeap(heap);
        }
        
        public int ExtractMax()
        {
            int max = heap[0];
            Swap(0, heapSize - 1);
            --heapSize;
            HeapifyDown(0);
            return max;
        }
        
        private void HeapifyDown(int i)
        {
            while(i < heapSize / 2)
            {
                int k = i;
                int left = Left(i);
                int right = Right(i);
                if (left < heapSize && heap[left] > heap[i])
                {
                    k = left;
                }
                if (right < heapSize && heap[k] < heap[right])
                {
                    k = right;
                }
                
                if (k == i)
                {
                    break;
                }
                else
                {
                    Swap(k, i);
                    i = k;
                }
            }
        }
        
        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
        
        private int Left(int i)
        {
            return 2 * i + 1;
        }
        
        private int Right(int i)
        {
            return 2 * i + 2;
        }
        
        private void BuildHeap(int[] array)
        {
            for (int i = heapSize / 2; i >= 0; --i)
            {
                HeapifyDown(i);
            }
        }
    }
    
    public int FindKthLargest(int[] nums, int k) 
    {
        var heap = new Heap(nums);
        
        int kth = 0;
        for (int i = 0; i < k; ++i)
        {
            kth = heap.ExtractMax();
        }
        
        return kth;
    }
    
}