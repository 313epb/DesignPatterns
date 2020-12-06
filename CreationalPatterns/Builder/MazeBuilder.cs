namespace DesignPatterns.Builder
{
    public class MazeBuilder
    {
        protected MazeBuilder()
        {
        }

        public virtual void BuildMaze()
        {
        }

        public virtual void BuildRoom(int Room)
        {
        }

        public virtual void BuildDoor(int roomFrom, int roomTo)
        {
        }

        public virtual Maze.Maze GetMaze() => null;
    }
}