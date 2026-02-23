using System;
using System.Collections.Generic;
using System.Text;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    internal class Rook : Piece
    {
        string name;
        public Rook(string pieceName)
        {
            name = pieceName;
        }

        public override bool IsMovePossible(Coords startCoords, Coords endCoords)
        {
            int coefficentX = Math.Abs(endCoords.X - startCoords.X);
            int coefficentY = Math.Abs(endCoords.Y - startCoords.Y);

            if (coefficentX == 0 || coefficentY == 0)
                return true;
            else
                return false;
            ;
        }
    }
}
