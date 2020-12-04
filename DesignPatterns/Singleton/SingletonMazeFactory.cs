namespace DesignPatterns.Singleton
{
    public class SingletonMazeFactory
    {
        private SingletonMazeFactory(){}

        public static SingletonMazeFactory Instance()=> new SingletonMazeFactory();

    }
}