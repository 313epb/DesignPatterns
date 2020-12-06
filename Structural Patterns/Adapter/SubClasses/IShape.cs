using System.Drawing;

namespace Structural_Patterns.Adapter.SubClasses
{
    public interface IShape
    {
        void BoundingBox(out Point bottomLeft, out Point topRight);
        Manipulator CreateManipulator();
    }
}