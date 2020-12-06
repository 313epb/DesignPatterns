using System.Collections.Generic;
using System.Drawing;
using Structural_Patterns.Bridge.SubClasses;

namespace Structural_Patterns.Bridge
{
    public class Window
    {
        //Этот класс используется в различных наследниках, и при этом наследники могут не применять интерфейс этого класса, а получать его 
        //через конструктор или функцию GetWindowImp()
        private WindowImp _imp;
        private View _contents; // содержимое окна

        public Window(View view) => _contents=view;

        public WindowImp GetWindowImp()=> new WindowImp();

        // запросы, обрабатываемые окном
        public virtual void DrawContents() { }
        
    }
}