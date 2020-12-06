using DesignPatterns.Maze;

namespace DesignPatterns.AbstractFactory
{
    public class DoorNeedingSpell:Door
    {
        public string Spell { get; }

        public DoorNeedingSpell(Room room1, Room room2, string spell) : base(room1, room2)
        {
            Spell = spell;
        }
    }
}