using DesignPatterns.AbstractFactory;
using DesignPatterns.Maze;

namespace DesignPatterns.FactoryMethod
{
    public class BombedMazeGame:MazeGame
    {
        public override Wall MakeWall()=> new BombedWall();

        public override Room MakeRoom(int n) => new RoomWihABomb(n);
    }
}