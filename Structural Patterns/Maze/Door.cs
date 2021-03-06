﻿namespace Structural_Patterns.Maze
{
    public class Door:MapSite
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public Room OtherSideFrom(Room room) => _room1==room ? _room2 : _room2 == room ? _room1 :null;
        

        public Door Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
            return this;
        }

        public override void Enter()
        {
            throw new System.NotImplementedException();
        }
    }
}