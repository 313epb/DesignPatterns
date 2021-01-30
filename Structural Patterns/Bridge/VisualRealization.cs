namespace Structural_Patterns.Bridge
{
    public interface IVisualRealization
    {
        void DrawWalls(Maze.Maze maze);

        void DrawDoors(Maze.Maze maze);
    }
}