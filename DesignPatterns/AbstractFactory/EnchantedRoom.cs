using DesignPatterns.Maze;

namespace DesignPatterns.AbstractFactory
{
    public class EnchantedRoom:Room
    {
        public string Spell { get; }

        public EnchantedRoom(int roomNumber, string spell="") : base(roomNumber)
        {
            Spell = spell;
        }


    }
}