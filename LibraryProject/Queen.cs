using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    internal class Queen
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
            //int coefficentX = Math.Abs(startCoords.X - endCoords.X);
            //int coefficentY = Math.Abs(startCoords.Y - endCoords.Y);
            int sumOfStartCoords = startCoords.X + startCoords.Y;
            int sumOfEndCoords = endCoords.X + endCoords.Y;
            int diffOfStartCoords = Math.Abs(startCoords.X - startCoords.Y);
            int diffOfEndCoords = Math.Abs(endCoords.X - endCoords.Y);

            if (sumOfStartCoords == sumOfEndCoords
                || startCoords.X == endCoords.X
                || startCoords.Y == endCoords.Y
                || diffOfStartCoords == diffOfEndCoords)
                return true;
            else
                return false;
            ;
        }
    }
}
