using System;

namespace Structural_Patterns.Maze
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