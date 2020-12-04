using DesignPatterns.AbstractFactory;
using DesignPatterns.Maze;

namespace DesignPatterns.Prototype
{
    public class MazePrototypeFactory:AbstractMazeFactory
    {
        private Maze.Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        
        public MazePrototypeFactory(Maze.Maze prototypeMaze, Room prototypeRoom, Wall prototypeWall, Door prototypeDoor)
        {
            _prototypeMaze = prototypeMaze;
            _prototypeRoom = prototypeRoom;
            _prototypeWall = prototypeWall;
            _prototypeDoor = prototypeDoor;
        }

        public override Wall MakeWall() => (Wall) _prototypeWall.Clone();
        public override Door MakeDoor(Room r1, Room r2) => ((Door) _prototypeWall.Clone()).Initialize(r1, r2);
             
        public override Room MakeRoom(int n) => (Room)_prototypeRoom.Clone();
        
    }
}