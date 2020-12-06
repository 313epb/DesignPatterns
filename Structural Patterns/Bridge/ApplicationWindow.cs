using Structural_Patterns.Bridge.SubClasses;

namespace Structural_Patterns.Bridge
{
    public class ApplicationWindow:Window
    {
        public ApplicationWindow(View view) : base(view)
        {
        }

        public override void DrawContents()
        {
            base.DrawContents();
        }
    }
}