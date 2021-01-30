using System.Collections.Generic;

namespace Structural_Patterns.Composite
{
    public class CompositeEquipment:Equipment
    {
        public CompositeEquipment(string name, int wattPower) : base(name, wattPower)
        {
            _equipment= new List<Equipment>();
        }

        public override void Add(Equipment equipment)
        {
            _equipment.Add(equipment);
        }

        public override void Remove(Equipment equipment)
        {
            _equipment.Remove(equipment);
        }

        public override List<Equipment> CreatEquipments() => _equipment;

        private List<Equipment> _equipment;
    }
}