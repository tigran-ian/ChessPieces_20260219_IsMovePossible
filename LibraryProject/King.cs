using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    internal class King
    {
        //public int xCoord;
        //public int yCoord;

        //public King(int x, int y)
        //{
        //    xCoord = x;
        //    yCoord = y;
        //}

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
            int coefficentX = Math.Abs(startCoords.X - endCoords.X);
            int coefficentY = Math.Abs(startCoords.Y - endCoords.Y);
            if (coefficentX == 1 && coefficentY == 1
                || coefficentX == 1 && coefficentY == 0
                || coefficentX == 0 && coefficentY == 1)
                return true;
            else
                return false;
            ;
        }
    }
}
