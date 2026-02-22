using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    public class Board
    {
        public enum VerticalF {A = 0, B = 1, C = 2, D = 3, E = 4, F = 5, G = 6, H = 7 }
        public enum pieceColors
        {
            White,
            Black
        }

        public struct Coords
        {
            public int sX;
            public int sY;
            public int fX;
            public int fY;

            public Coords(int x1, int y1, int x2, int y2)
            {
                sX = x1;
                sY = y1;

                fX = x2;
                fY = y2;
            }
        }

        public Coords coords;
    };
}
