using System.Collections.Generic;

namespace DesignPatterns.Maze
{
    public class Maze
    {
        private List<Room> _rooms= new List<Room>();

        public void AddRoom(Room room) => _rooms.Add(room);

        public Room RoomNo(int roomNumber) => _rooms[roomNumber];
    }
}