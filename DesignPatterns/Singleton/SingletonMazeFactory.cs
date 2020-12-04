namespace DesignPatterns.Singleton
{
    public class SingletonMazeFactory:Singleton
    {
        private SingletonMazeFactory(){}

        public static readonly SingletonMazeFactory _instance= new SingletonMazeFactory();


    }
}