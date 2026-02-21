using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    public class Board
    {
        public enum vFiles {A, B, C, D, E, F, G, H }
        public enum pieceColors
        {
            White,
            Black
        }

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

        public Coords coords;
    };
}
