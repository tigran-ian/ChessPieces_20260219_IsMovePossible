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

            if(name == "White")
            {
                if (startCoorts.X == 1 && coefficentX <= 2)
                    return true;
                else if(startCoorts.X != 1 && coefficentX == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            else if(name == "Black")
            {
                if (startCoorts.X == 7 && coefficentX <= -2)
                    return true;
                else if (startCoorts.X != 7 && coefficentX == -1)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
