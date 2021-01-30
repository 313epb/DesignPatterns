using System.Collections.Generic;
using System.Linq;

namespace Structural_Patterns.Maze
{
    public class Maze
    {
        private List<Room> _rooms= new List<Room>();

        public void AddRoom(Room room) => _rooms.Add(room);

        public Room RoomNo(int roomNumber) => _rooms.FirstOrDefault(r=>r.RoomNumber==roomNumber);
    }
}