namespace Structural_Patterns.Adapter.SubClasses
{
    public class Coord
    {
        public int X { get; } = 0;
        
        public Coord(){}

        public Coord(int x)
        {
            X = x;
        }
        
        public static explicit operator int(Coord coord) => coord.X;

    }
}