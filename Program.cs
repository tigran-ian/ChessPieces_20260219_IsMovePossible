using ChessPieces_20260219_IsMovePossible.LibraryProject;

//Ունենալ Library Project որտեղ սահմանված կլինեն շախմատին վերաբերվող ապստրակցիները՝
//Coordinate, Board, Folder որտեղ խաղաքարերը կլինեն և նրանք կունենան մեթոդներ
//bool IsMovePossible(Coord startCoord, Coord endCoord), որը կվերադարձնի ամեն
//քարի համար true եթե ներմուծված սկզբնակետից վերջնակետ մեկ քայլով տվյալ խաղաքարը
//կարող է գնալ։
//Ունենալ նաև Console Project որտեղ կկատարվեն ներմուծելու և տպելու գործառույթները։

Board board = new Board();
Piece piece = null;

Console.WriteLine("Please enter piece name: ");
string pieceName = Console.ReadLine();

Console.WriteLine("Please enter starting coordinates: ");
board.EnterCoordinates(out string startPosCoords, out int startX, out int startY);

Console.WriteLine("Please enter target coordinates: ");
board.EnterCoordinates(out string finishPosCoords, out int finishX, out int finishY);

Piece.Coords startCoord = new Piece.Coords(startX, startY);
Piece.Coords finishCoord = new Piece.Coords(finishX, finishY);

switch (pieceName)
{
    case "King":
        piece = new King(pieceName);
        break;
    case "Queen":
        piece = new King(pieceName);
        break;
    case "Rook":
        piece = new Rook(pieceName);
        break;
    case "Bishop":
        piece = new Bishop(pieceName);
        break;
    case "Knight":
        piece = new Knight(pieceName);
        break;
    case "Pawn":
        Console.WriteLine("Please enter piece color: ");
        string pieceColor = Console.ReadLine();
        piece = new Pawn(pieceName, pieceColor);
        break;
    default:
        break;
}

bool canMove = piece.IsMovePossible(startCoord, finishCoord);
CheckMovingStatus(canMove);

//Queen queen = new Queen();

//Queen.Coords startCoord = new Queen.Coords(startX, startY);
//Queen.Coords finishCoord = new Queen.Coords(finishX, finishY);

//bool canMove = queen.IsMovePossible(startCoord, finishCoord);

void CheckMovingStatus(bool status)
{
    if (status)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
