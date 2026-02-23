using System;
using System.Collections.Generic;
using System.Text;
using static ChessPieces_20260219_IsMovePossible.LibraryProject.Piece;

namespace ChessPieces_20260219_IsMovePossible.LibraryProject
{
    public class Pawn : Piece
    {
        string name;
        string color;


        public Pawn(string pieceName, string pieceColor)
        {
            name = pieceName;
            color = pieceColor;
        }

        public override bool IsMovePossible(Coords startCoords, Coords endCoords)
        {
            int coefficentX = endCoords.X - startCoords.X;
            int coefficentY = endCoords.Y - startCoords.Y;

            if (coefficentX == coefficentY)
                return true;
            else
                return false;
        }
    }
}
