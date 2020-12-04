using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;

namespace DesignPatterns.Maze
{
    public class MazeGame
    {

        #region Оригинал

        public Maze CreateMazeGame()
        {
            var maze= new Maze();
            var room1= new Room(1);
            var room2= new Room(2);
            var door= new Door(room1,room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North,new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.West,new Wall());
            room1.SetSide(Direction.South,new Wall());

            room2.SetSide(Direction.North,new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.South,new Wall());

            return maze;
        }

        #endregion

        #region Абстрактная фабрика

        public Maze CreateMazeGame(AbstractMazeFactory abstractMazeFactory)
        {
            var maze = abstractMazeFactory.MakeMaze();
            var room1 = abstractMazeFactory.MakeRoom(1);
            var room2 = abstractMazeFactory.MakeRoom(2);
            var door = abstractMazeFactory.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, abstractMazeFactory.MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.West, abstractMazeFactory.MakeWall());
            room1.SetSide(Direction.South, abstractMazeFactory.MakeWall());

            room2.SetSide(Direction.North, abstractMazeFactory.MakeWall());
            room2.SetSide(Direction.East, abstractMazeFactory.MakeWall());
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.South, abstractMazeFactory.MakeWall());

            return maze;

        }

        #endregion

        #region Строитель (Builder)
        //Director (распорядитель)
        public Maze CreateMazeGame(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1,2);

            return builder.GetMaze();
        }

        #endregion

        #region Фабричный метод

        public virtual Maze MakeMaze() => new Maze();

        public virtual Room MakeRoom(int n) => new Room(n);

        public virtual Wall MakeWall() => new Wall();

        public virtual Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);

        public Maze CreateMaze()
        {
            var maze = MakeMaze();
            var room1 = MakeRoom(1);
            var room2 = MakeRoom(2);
            var door = MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.West, MakeWall());
            room1.SetSide(Direction.South, MakeWall());

            room2.SetSide(Direction.North, MakeWall());
            room2.SetSide(Direction.East, MakeWall());
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.South, MakeWall());

            return maze;
        }

        #endregion
    }
}