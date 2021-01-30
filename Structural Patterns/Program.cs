using Structural_Patterns.Adapter;
using Structural_Patterns.Adapter.SubClasses;
using Structural_Patterns.Bridge;
using Structural_Patterns.Decorator;
using Structural_Patterns.Maze;

namespace Structural_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new MazeGame();


            //Адаптер позволяет работать с Maze  в терминах другого объекта Field
            IField fieldObj = new MazeFieldAdapter(game.CreateMazeGame());
            
            //Bridge позволяет разделять реализации и не плодить классы для разных реализаций
            var grphicMaze = new GraphicMazeBridge(game.CreateMazeGame(), new ThreeDRealization());

            //Декоратор позволяет расширять возможности класса, при этом не плодя прямых наследников
            Decorator.Decorator aMaze = new RedBoardedMaze(new ThickWallDecorator(game.CreateMazeGame()));

        }
    }
}
