using Structural_Patterns.Bridge.SubClasses;

namespace Structural_Patterns.Bridge
{
    public class IconWindow:Window
    {
        public IconWindow(View view) : base(view)
        {
        }

        public override void DrawContents()
        {
            base.DrawContents();
        }
    }
}