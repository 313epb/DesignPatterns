namespace DesignPatterns.Maze
{
    public enum Direction
    {
        North,
        South, 
        East,
        West
    }

    public static class DirectionFuncs
    {
        public static Direction OppositeDirection(Direction direction)
        {
            return direction == Direction.North ? Direction.South :
                direction == Direction.South ? Direction.North :
                direction == Direction.East ? Direction.West : Direction.East;
        }
    }
}