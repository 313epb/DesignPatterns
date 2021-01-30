using System.Collections.Generic;

namespace Structural_Patterns.Composite
{
    public abstract class Equipment
    {
        public string Name { get; }

        public int WattPower { get; }

        public Equipment(string name, int wattPower)
        {
            Name = name;
            WattPower = wattPower;
        }
        

        public abstract void Add(Equipment equipment);

        public abstract void Remove(Equipment equipment);

        public abstract List<Equipment> CreatEquipments();
    }
}