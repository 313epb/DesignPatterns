namespace Structural_Patterns.Maze
{
    public class Room:MapSite
    {
        private MapSite[] _sides= new MapSite[4];

        public int RoomNumber { get; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            if (_sides.Length > (int) direction && mapSite!=null) 
                _sides[(int) direction] = mapSite;
        }

        public override void Enter()
        {
            throw new System.NotImplementedException();
        }
    }
}