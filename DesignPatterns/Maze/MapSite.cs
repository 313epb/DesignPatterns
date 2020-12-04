using System;

namespace DesignPatterns.Maze
{
    public abstract class MapSite:ICloneable
    {
        public abstract void Enter();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}