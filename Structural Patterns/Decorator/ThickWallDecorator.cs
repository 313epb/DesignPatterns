namespace Structural_Patterns.Decorator
{
    public class ThickWallDecorator : Decorator
    {
        public ThickWallDecorator(Maze.Maze maze) : base(maze)
        {
        }

        public override void Draw()
        {
            DrawThickWall();
        }

        private void DrawThickWall()
        {
        }
    }
}