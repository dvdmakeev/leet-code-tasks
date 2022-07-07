public class Solution 
{
    class Room
    {
        public Room(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
        
        public int i;
        public int j;
    }
    
    public void WallsAndGates(int[][] rooms) 
    {
        const int gate = 0;
        const int wall = -1;
        const int empty = 2147483647;
        
        var queue = new Queue<Room>();
        for (int i = 0; i < rooms.Length; ++i)
        {
            for (int j = 0; j < rooms[i].Length; ++j)
            {
                if (rooms[i][j] == gate)
                {
                    queue.Enqueue(new Room(i, j));
                }
            }
        }
        
        while (queue.Count > 0)
        {
            var room = queue.Dequeue();
            int roomDistance = rooms[room.i][room.j];
            
            foreach (Room neighbour in GetNeighbours(room))
            {
                if (neighbour.i >= 0 && neighbour.j >= 0 && 
                    neighbour.i < rooms.Length && neighbour.j < rooms[neighbour.i].Length)
                {
                    if (rooms[neighbour.i][neighbour.j] == empty)
                    {
                        rooms[neighbour.i][neighbour.j] = roomDistance + 1;
                        queue.Enqueue(neighbour);   
                    }
                }
            }
        }
    }
    
    private Room[] GetNeighbours(Room room)
    {
        var neighbours = new Room[4];
        
        neighbours[0] = new Room(room.i + 1, room.j);
        neighbours[1] = new Room(room.i - 1, room.j);
        neighbours[2] = new Room(room.i, room.j + 1);
        neighbours[3] = new Room(room.i, room.j - 1);
        
        return neighbours;
    }
}
