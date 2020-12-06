using System.Collections.Generic;

namespace DesignPatterns.Singleton
{
    public abstract class Singleton
    {
        private static Dictionary<string,Singleton> _registry = new Dictionary<string, Singleton>();

        public static void Register(string name, Singleton singleton)
        {
            _registry.TryAdd(name,singleton);
        }

        public static Singleton Lookup(string name) => _registry[name];


    }
}