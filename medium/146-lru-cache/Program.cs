  public class LRUCache
  {
    private class ListNode
    {
      public ListNode next;
      public ListNode prev;

      public int key;
      public int value;
    }

    private Dictionary<int, ListNode> cache = new Dictionary<int, ListNode>();
    private ListNode head;
    private ListNode tail;

    private readonly int capacity;

    public LRUCache(int capacity)
    {
      this.capacity = capacity;
    }

    public int Get(int key)
    {
      if (!cache.ContainsKey(key))
      {
        return -1;
      }

      ListNode cacheNode = cache[key];

      MoveToTail(cacheNode);

      return cacheNode.value;
    }

    private void MoveToTail(ListNode node)
    {
      // node is already in the tail
      if (node.next == null)
      {
        return;
      }

      // node is in the head
      if (node.prev == null)
      {
        head = node.next;
        head.prev = null;
        tail.next = node;
        node.prev = tail;
        tail = node;
        tail.next = null;

        return;
      }

      node.prev.next = node.next;
      node.next.prev = node.prev;
      tail.next = node;
      node.prev = tail;
      tail = node;
      tail.next = null;
    }

    public void Put(int key, int value)
    {
      if (cache.ContainsKey(key))
      {
        ListNode cacheNode = cache[key];
        cacheNode.value = value;
        MoveToTail(cacheNode);

        return;
      }

      if (cache.Count >= capacity)
      {
        var removedNode = RemoveHead();
        if (removedNode != null)
        {
          cache.Remove(removedNode.key);
        }
      }

      var node = new ListNode();
      node.key = key;
      node.value = value;
      if (head == null)
      {
        head = node;
      }
      if (tail == null)
      {
        tail = node;
      }
      else
      {
        tail.next = node;
        node.prev = tail;
        tail = node;
        node.next = null;
      }

      cache[key] = node;
    }

    private ListNode RemoveHead()
    {
      if (head == null)
      {
        return null;
      }

      if (tail == head)
      {
        var removedHead = head;
        head = null;
        tail = null;

        return removedHead;
      }
      else
      {
        var removedHead = head;

        head = head.next;
        head.prev = null;
        return removedHead;
      }
    }
  }

  /**
   * Your LRUCache object will be instantiated and called as such:
   * LRUCache obj = new LRUCache(capacity);
   * int param_1 = obj.Get(key);
   * obj.Put(key,value);
   */