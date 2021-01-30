namespace Structural_Patterns.Decorator
{
    public class Decorator:Maze.Maze
    {
        private Maze.Maze _maze;

        public Decorator(Maze.Maze maze)
        {
            _maze = maze;
        }

        public virtual void Draw() { }
    }
}