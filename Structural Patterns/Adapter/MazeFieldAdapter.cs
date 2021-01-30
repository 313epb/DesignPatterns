using System;
using System.Collections.Generic;
using Structural_Patterns.Adapter.SubClasses;
using Structural_Patterns.Maze;

namespace Structural_Patterns.Adapter
{

    //Допустим у нас есть набор функции работающих с IField
    // и нам нужно сделать так, чтобы они могли работать и с лабиринтом
    //создаётся адаптер, с помощью которого функции Maze реализуются в терминах IField

    public class MazeFieldAdapter:MazeGame, IField
    {

        private List<Element> elements;
        private Maze.Maze _mazeGame;

        public MazeFieldAdapter(Maze.Maze maze)
        {
            _mazeGame = maze;
        }

        public IField Draw()
        {
            //реализация создания игры в терминах IField
            _mazeGame = CreateMazeGame();
            return this;
        }

        public IField AddSubField()
        {
            _mazeGame.AddRoom(new Room(1));
            return this;
        }

        public List<Element> AddElements(Element element)
        {
            _mazeGame.AddRoom(ElementConverter(element));
            elements.Add(element);
            return elements;
        }

        private Room ElementConverter(Element element)
        {
            return  new Room(1);
        }

        //и т.д.
        public char GetEntrance()
        {
            throw new System.NotImplementedException();
        }

        public char GetOrientation()
        {
            throw new System.NotImplementedException();
        }
    }
}