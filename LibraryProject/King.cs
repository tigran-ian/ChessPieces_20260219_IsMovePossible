using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    internal class King
    {
        

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
        public bool IsMovePossible(Coords startCoords, Coords endCoords)
        {
            Console.WriteLine(startCoords.X);
            Console.WriteLine(startCoords.Y);

            Console.WriteLine(endCoords.X);
            Console.WriteLine(endCoords.Y);

            return true;
        }
    }
}
