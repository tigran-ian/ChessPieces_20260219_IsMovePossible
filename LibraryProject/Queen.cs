using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    public class Queen : Piece
    {
        public string name;
        public Queen(string pieceName)
        {
            name = pieceName;
        }
        public override bool IsMovePossible(Coords startCoords, Coords endCoords)
        {
            int coefficentX = Math.Abs(endCoords.X - startCoords.X);
            int coefficentY = Math.Abs(endCoords.Y - startCoords.Y);

            if (coefficentX == 0 || coefficentY == 0 || coefficentX == coefficentY)
                return true;
            else
                return false;
            ;
        }
    }
}
