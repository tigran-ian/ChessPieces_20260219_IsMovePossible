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

        public void EnterCoordinates(out string coords, out int x, out int y)
        {
            coords = Console.ReadLine();

            y = (int)Enum.Parse<Board.VerticalF>(coords[0].ToString());
            bool isNum = int.TryParse(coords[1].ToString(), out x);
            x -= 1;
        }
    };
}
