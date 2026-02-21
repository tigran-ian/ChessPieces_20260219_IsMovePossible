using ChessPieces_20260219_IsMovePossible.LibraryProject;

//Ունենալ Library Project որտեղ սահմանված կլինեն շախմատին վերաբերվող ապստրակցիները՝
//Coordinate, Board, Folder որտեղ խաղաքարերը կլինեն և նրանք կունենան մեթոդներ
//bool IsMovePossible(Coord startCoord, Coord endCoord), որը կվերադարձնի ամեն
//քարի համար true եթե ներմուծված սկզբնակետից վերջնակետ մեկ քայլով տվյալ խաղաքարը
//կարող է գնալ։
//Ունենալ նաև Console Project որտեղ կկատարվեն ներմուծելու և տպելու գործառույթները։

Board board = new Board();

Console.WriteLine("Please enter starting coordinates: ");
string startPosCoords = Console.ReadLine();

var startX = (int)Enum.Parse<Board.VerticalF>(startPosCoords[0].ToString());

string startYTxt = startPosCoords[1].ToString();

bool isNum = int.TryParse(startYTxt, out int startY);

if(isNum)
    board.coords = new Board.Coords(startX, startY);
else
    Console.WriteLine("Please enter valid coordinates");

Console.WriteLine($"X is: {startX}");
Console.WriteLine($"Y is: {startY}");

//Console.WriteLine($"{(byte)Board.vFiles.E}");
