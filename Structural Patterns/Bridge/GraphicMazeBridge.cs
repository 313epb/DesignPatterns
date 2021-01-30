namespace Structural_Patterns.Bridge
{
    public class GraphicMazeBridge
    {
        public Maze.Maze Maze1 { get; }

        public IVisualRealization Realization { get; }

        public GraphicMazeBridge(Maze.Maze maze, IVisualRealization realization)
        {
            Maze1 = maze;
            Realization = realization;
        }

        void DrawMaze() { Realization.DrawDoors(Maze1); Realization.DrawWalls(Maze1);}
    }


}