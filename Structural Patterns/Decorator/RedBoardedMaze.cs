namespace Structural_Patterns.Decorator
{
    public class RedBoardedMaze:Decorator
    {
        public RedBoardedMaze(Maze.Maze maze) : base(maze)
        {
        }

        public override void Draw()
        {
            DrawRedBorder();
        }

        private void DrawRedBorder() { }
    }
}