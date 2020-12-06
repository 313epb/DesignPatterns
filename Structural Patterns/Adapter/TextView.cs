using Structural_Patterns.Adapter.SubClasses;

namespace Structural_Patterns.Adapter
{
    public class TextView
    {
        private Coord _x = new Coord();
        private Coord _y = new Coord();
        private Coord _height = new Coord();
        private Coord _width = new Coord();

        public TextView(){}

        public TextView(int x, int y, int height, int width)
        {
            _x = new Coord(x);
            _y = new Coord(y);
            _height = new Coord(height);
            _width = new Coord(width);
        }
        
        public void GetOrigin(out Coord x, out Coord y)
        {
            x = _x;
            y = _y;
        }
        
        public void GetExtent(out Coord width, out Coord height)
        {
            width = _width;
            height = _height;
        }

    }
}