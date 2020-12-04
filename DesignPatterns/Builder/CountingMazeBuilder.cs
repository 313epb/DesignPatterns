namespace DesignPatterns.Builder
{
    public class CountingMazeBuilder:MazeBuilder
    {
        public override void BuildDoor(int roomFrom, int roomTo) => _doors++;

        public override void BuildRoom(int Room) => _rooms++;

        public void GetCounts(out int d,out int r)
        {
            d = _doors;
            r = _rooms;
        }

        private int _doors = 0;
        private int _rooms = 0;
    }
}