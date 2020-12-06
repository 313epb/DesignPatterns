using DesignPatterns.Maze;

namespace DesignPatterns.AbstractFactory
{
    public class RoomWihABomb:Room
    {
        public bool _isDetonated = false;

        public RoomWihABomb(int roomNumber) : base(roomNumber)
        {
        }

        public void Detonate()
        {

        }
    }
}