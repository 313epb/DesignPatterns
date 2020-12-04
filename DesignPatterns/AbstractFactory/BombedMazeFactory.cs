using DesignPatterns.Maze;

namespace DesignPatterns.AbstractFactory
{
    public class BombedMazeFactory:AbstractMazeFactory
    {
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int n)
        {
            return new RoomWihABomb(n);
        }
    }
}