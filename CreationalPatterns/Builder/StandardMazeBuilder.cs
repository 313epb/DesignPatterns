using System;
using DesignPatterns.Maze;

namespace DesignPatterns.Builder
{
    public class StandardMazeBuilder:MazeBuilder
    {
        private Maze.Maze _currentMaze;

        public StandardMazeBuilder()
        {
            _currentMaze = null;
        }

        public override void BuildMaze()
        {
            _currentMaze= new Maze.Maze();
        }

        public override Maze.Maze GetMaze() => _currentMaze;

        public override void BuildRoom(int n)
        {
            if (_currentMaze.RoomNo(n)==null)
            {
                var room = new Room(n);
                _currentMaze.AddRoom(room);

                room.SetSide(Direction.North,new Wall());
                room.SetSide(Direction.South,new Wall());
                room.SetSide(Direction.East,new Wall());
                room.SetSide(Direction.West,new Wall());
            }
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            var r1 = _currentMaze.RoomNo(roomFrom);
            var r2 = _currentMaze.RoomNo(roomTo);
            var door = new Door(r1, r2);

            var commonWall = CommonWall();

            r1.SetSide(commonWall,door);
            r2.SetSide(DirectionFuncs.OppositeDirection(commonWall),door);
        }

        private Direction CommonWall()
        {
            var values = Enum.GetValues(typeof(Direction));
            Random random = new Random();
            return (Direction)values.GetValue(random.Next(values.Length));
        }

    }
}