using DesignPatterns.AbstractFactory;
using DesignPatterns.Maze;

namespace DesignPatterns.FactoryMethod
{
    public class EnchantedMazeGame:MazeGame
    {
        public override Room MakeRoom(int n) => new EnchantedRoom(n,CastSpell());

        public override Door MakeDoor(Room r1, Room r2) => new DoorNeedingSpell(r1,r2,CastSpell());

        protected string CastSpell() => "Wish";
    }
}