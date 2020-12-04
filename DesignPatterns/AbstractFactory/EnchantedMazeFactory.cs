using DesignPatterns.Maze;

namespace DesignPatterns.AbstractFactory
{
    public class EnchantedMazeFactory:AbstractMazeFactory
    {
        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1,r2,CastSpell());
        }

        protected string CastSpell() => "Spell";
    }
}