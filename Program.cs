using ChessPieces_20260219_IsMovePossible.LibraryProject;

//Ունենալ Library Project որտեղ սահմանված կլինեն շախմատին վերաբերվող ապստրակցիները՝
//Coordinate, Board, Folder որտեղ խաղաքարերը կլինեն և նրանք կունենան մեթոդներ
//bool IsMovePossible(Coord startCoord, Coord endCoord), որը կվերադարձնի ամեն
//քարի համար true եթե ներմուծված սկզբնակետից վերջնակետ մեկ քայլով տվյալ խաղաքարը
//կարող է գնալ։
//Ունենալ նաև Console Project որտեղ կկատարվեն ներմուծելու և տպելու գործառույթները։

Board board = new Board();
Console.WriteLine("Please enter piece name: ");
string name = Console.ReadLine();

Console.WriteLine("Please enter starting coordinates: ");
board.EnterCoordinates(out string startPosCoords, out int startX, out int startY);

Console.WriteLine("Please enter target coordinates: ");
board.EnterCoordinates(out string finishPosCoords, out int finishX, out int finishY);

King king = new King(name);
Queen queen = new Queen();

king.PrintName(name);

//King.Coords startCoord = new King.Coords(startX, startY);
//King.Coords finishCoord = new King.Coords(finishX, finishY);

Queen.Coords startCoord = new Queen.Coords(startX, startY);
Queen.Coords finishCoord = new Queen.Coords(finishX, finishY);

//bool canMove = king.IsMovePossible(startCoord, finishCoord);
bool canMove = queen.IsMovePossible(startCoord, finishCoord);

if (canMove)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

//Console.WriteLine($"{(byte)Board.vFiles.E}");
