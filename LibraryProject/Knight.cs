using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    public class Knight : Piece
    {
        string name;

        public Knight(string pieceName)
        {
            name = pieceName;
        }

        public override bool IsMovePossible(Coords startCoords, Coords endCoords)
        {
            int coefficentX = Math.Abs(endCoords.X - startCoords.X);
            int coefficentY = Math.Abs(endCoords.Y - startCoords.Y);

            if(coefficentX == 2 && coefficentY == 1 || coefficentX == 1 && coefficentY == 2)
                return true;
            else
                return false;
        }
    }
}
