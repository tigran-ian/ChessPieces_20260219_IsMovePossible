using ChessPieces_20260219_IsMovePossible.LibraryProject;

//Ունենալ Library Project որտեղ սահմանված կլինեն շախմատին վերաբերվող ապստրակցիները՝
//Coordinate, Board, Folder որտեղ խաղաքարերը կլինեն և նրանք կունենան մեթոդներ
//bool IsMovePossible(Coord startCoord, Coord endCoord), որը կվերադարձնի ամեն
//քարի համար true եթե ներմուծված սկզբնակետից վերջնակետ մեկ քայլով տվյալ խաղաքարը
//կարող է գնալ։
//Ունենալ նաև Console Project որտեղ կկատարվեն ներմուծելու և տպելու գործառույթները։

Board board = new Board();

Console.WriteLine("Please enter starting coordinates: ");
EnterCoordinates(out string startPosCoords, out int startX, out int startY);

Console.WriteLine("Please enter target coordinates: ");
EnterCoordinates(out string finishPosCoords, out int finishX, out int finishY);

board.coords = new Board.Coords(startX, startY, finishX, finishY);

Console.WriteLine($"Starting X is: {board.coords.sX}");
Console.WriteLine($"Starting Y is: {board.coords.sY}");

Console.WriteLine($"Finishing X is: {board.coords.fX}");
Console.WriteLine($"Finishing Y is: {board.coords.fY}");

void EnterCoordinates(out string coords,out int x, out int y)
{
    coords = Console.ReadLine();

    y = (int)Enum.Parse<Board.VerticalF>(coords[0].ToString());
    bool isNum = int.TryParse(coords[1].ToString(), out x);
    x -= 1;
}

//Console.WriteLine($"{(byte)Board.vFiles.E}");
