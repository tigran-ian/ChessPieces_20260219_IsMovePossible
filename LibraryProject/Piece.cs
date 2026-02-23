using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    public abstract class Piece
    {
        public string name;
        public string color;

        public struct Coords
        {
            public int X;
            public int Y;

            public Coords(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        
        public abstract bool IsMovePossible(Coords start, Coords end);
    }
}
