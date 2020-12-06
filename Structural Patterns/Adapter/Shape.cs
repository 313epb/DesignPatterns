using System.Drawing;
using Structural_Patterns.Adapter.SubClasses;

namespace Structural_Patterns.Adapter
{
    public class Shape:IShape
    {
        private Point _bottomLeft = new Point();
        private Point _topRight = new Point();

        public Shape(){}

        public Shape(Point bottomLeft, Point topRight)
        {
            _bottomLeft = bottomLeft;
            _topRight = topRight;
        }

        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            bottomLeft = _bottomLeft;
            topRight = _topRight;
        }

        public Manipulator CreateManipulator()
        {
            throw new System.NotImplementedException();
        }
    }
}