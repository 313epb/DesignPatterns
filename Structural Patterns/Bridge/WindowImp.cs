using System.Drawing;
using Structural_Patterns.Adapter.SubClasses;

namespace Structural_Patterns.Bridge
{
    public class WindowImp
    {
        public virtual void ImpTop(){}
        public virtual void ImpBottom(){}
        public virtual void ImpSetExtent(Point point) { }
        public virtual void ImpSetOrigin(Point point) { }
        public virtual void DeviceRect(Coord bl, Coord br, Coord tl, Coord tr) { }
        public virtual void DeviceText(string text, Coord bl, Coord tr) { }
        public virtual void DeviceBitmap(string text, Coord bl, Coord tr) { }

    }
}