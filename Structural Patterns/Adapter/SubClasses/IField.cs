using System.Collections.Generic;

namespace Structural_Patterns.Adapter.SubClasses
{
    public interface IField
    {
        IField Draw();

        IField AddSubField();

        List<Element> AddElements(Element element);
        
        char GetEntrance();

        char GetOrientation();
    }
}