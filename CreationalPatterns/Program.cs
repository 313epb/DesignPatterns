using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Maze;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new MazeGame();
            var bombedMaze = new BombedMazeFactory();
            var enchantedMaze = new EnchantedMazeFactory();
            var builder = new StandardMazeBuilder();
            var countingBuilder =  new CountingMazeBuilder();
            var bombedMazeGame =  new BombedMazeGame();
            var enchantedMazeGame = new EnchantedMazeGame();
            var simpleMazeFactory = new MazePrototypeFactory(new Maze.Maze(), new Room(1), new Wall(),
                new Door(new Room(2), new Room(2)));
            var bombedMazeFactory = new MazePrototypeFactory(new Maze.Maze(), new RoomWihABomb(1), new BombedWall(),
                new Door(new Room(2), new Room(2)));
            Singleton.Singleton.Register("SingletonMazeFactory", SingletonMazeFactory._instance);

            //Оригинал без паттернов
            game.CreateMazeGame();

            //Абстрактная фабрика
            game.CreateMazeGame(bombedMaze);
            game.CreateMazeGame(enchantedMaze);

            //Строитель (BUilder)
            game.CreateMazeGame(builder);
            game.CreateMazeGame(countingBuilder);
            countingBuilder.GetCounts(out var r, out var d );

            //Фабричный метод
            bombedMazeGame.CreateMaze();
            enchantedMazeGame.CreateMaze();

            //Прототип
            game.CreateMazeGame(simpleMazeFactory);
            game.CreateMazeGame(bombedMazeFactory);

            //Синглтон
            var mazeFactory = Singleton.Singleton.Lookup("SingletonMazeFactory");
        }
    }
}
