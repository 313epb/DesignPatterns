using DesignPatterns.Maze;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractMazeFactory
    {
        public virtual Maze.Maze MakeMaze() => new Maze.Maze();

        public virtual Wall MakeWall() => new Wall();

        public virtual Room MakeRoom(int n) => new Room(n);

        public virtual Door MakeDoor(Room r1, Room r2) => new Door(r1,r2);
    }
}