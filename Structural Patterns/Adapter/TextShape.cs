using System.Drawing;
using Structural_Patterns.Adapter.SubClasses;

//Адаптирует TextView к IShape
namespace Structural_Patterns.Adapter
{
    public class TextShape: TextView,IShape
    {
        public void BoundingBox(out Point bottomLeft,out Point topRight)
        {
            GetOrigin(out var bottom, out var left);
            GetExtent(out var width,out var height);
            bottomLeft =new  Point((int)bottom,(int)left);
            topRight = new Point((int) bottom + (int) height, (int) left + (int) width);
        }

        public Manipulator CreateManipulator()
        {
            return new Manipulator();
        }

        public virtual bool IsEmpty() => true;
    }
}