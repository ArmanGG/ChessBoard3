using System.Collections.Generic;
PossMas possMas = new PossMas();
Possition p1 = new Possition(8, 'A', ' ');
StartGame();

void StartGame()
{


    bool b = true;
    do
    {
        Console.WriteLine("                              Insert Game mode ` Game1 or Game2 or Game3");
        Console.SetCursorPosition(30, 1);
        string GameMode = Console.ReadLine();
        if (GameMode == "Game1")
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                                                                    ");
            CreateСhessBoard();
            start();
            b = false;
        }
        else if (GameMode == "Game2")
        {
            CreateСhessBoard();
            KnightCheck();
            b = false;
        }
        else if (GameMode == "Game3")
        {
            CreateСhessBoard();
            start1();
            b = false;
        }
        else
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");
            Console.SetCursorPosition(0, 0);
        }

    } while (b == true);

}

void start1()
{
    int count = 0;
    while (count < 3)
    {
        Console.SetCursorPosition(0, 9);
        Console.WriteLine("Insert Possition(A8,B4,C3....)");
        Console.SetCursorPosition(0, 10);
        Console.WriteLine("Insert Figure(K,Q,B,N,R)");
        int poss = 9;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(30, poss);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(30, poss + 1);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(30, poss);
        string s1 = Console.ReadLine();
        Console.SetCursorPosition(0, 11);
        Console.WriteLine("                          ");
        Console.SetCursorPosition(30, poss + 1);
        string s3 = Console.ReadLine();
        bool b = CheckPoss(s1, s3);

        if (b == true)
        {

            count++;
        }

    }
    Console.SetCursorPosition(0, 12);
    Start2();
}
void Start2()
{

    char s;
    for (int i = 0; i <= 8; i++)
    {
        for (int j = 0; j <= 8; j++)
        {
            s = possMas.Read(i, j * 2);
            if (s == 'K')
            {
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        if (x == 0 && y == 0)
                            continue;

                        int newX = i + x;
                        int newY = j + y;

                        if (newX >= 0 && newX <= 8 && newY >= 0 && newY <= 8)
                        {
                            if (possMas.Read(newX, newY * 2) == '\0')
                            {
                                WriteLinePoss1(newX, newY * 2, '2');
                                possMas.Write(newX, newY * 2, '2');
                            }
                            else if (possMas.Read(newX, newY * 2) == '2')
                            {
                                WriteLinePoss2(newX, newY * 2, '2');
                                possMas.Write(newX, newY * 2, '2');
                            }
                        }
                    }
                }
            }
            else if (s == 'R')
            {
                for (int x = -1; x <= 1; x += 2)
                {
                    if (x == 0)
                        continue;

                    int newX = i;
                    int newY = j;

                    while (true)
                    {
                        newX += x;

                        if (newX < 0 || newX > 8)
                            break;

                        if (possMas.Read(newX, newY * 2) == '\0')
                        {
                            WriteLinePoss1(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else if (possMas.Read(newX, newY * 2) == '2')
                        {
                            WriteLinePoss2(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                for (int y = -1; y <= 1; y += 2)
                {
                    if (y == 0)
                        continue;

                    int newX = i;
                    int newY = j;

                    while (true)
                    {
                        newY += y;

                        if (newY < 0 || newY > 8)
                            break;

                        if (possMas.Read(newX, newY * 2) == '\0')
                        {
                            WriteLinePoss1(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else if (possMas.Read(newX, newY * 2) == '2')
                        {
                            WriteLinePoss2(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else if (s == 'Q')
            {
                for (int x = -1; x <= 1; x += 2)
                {
                    if (x == 0)
                        continue;

                    int newX = i;
                    int newY = j;

                    while (true)
                    {
                        newX += x;

                        if (newX < 0 || newX > 8)
                            break;

                        if (possMas.Read(newX, newY * 2) == '\0')
                        {
                            WriteLinePoss1(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else if (possMas.Read(newX, newY * 2) == '2')
                        {
                            WriteLinePoss2(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                for (int x = -1; x <= 1; x += 2)
                {
                    for (int y = -1; y <= 1; y += 2)
                    {
                        int newX = i;
                        int newY = j;

                        while (true)
                        {
                            newX += x;
                            newY += y;

                            if (newX < 0 || newX > 8 || newY < 0 || newY > 8)
                                break;

                            if (possMas.Read(newX, newY * 2) == '\0')
                            {
                                WriteLinePoss1(newX, newY * 2, '2');
                                possMas.Write(newX, newY * 2, '2');
                            }
                            else if (possMas.Read(newX, newY * 2) == '2')
                            {
                                WriteLinePoss2(newX, newY * 2, '2');
                                possMas.Write(newX, newY * 2, '2');
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }


                for (int y = -1; y <= 1; y += 2)
                {
                    if (y == 0)
                        continue;

                    int newX = i;
                    int newY = j;

                    while (true)
                    {
                        newY += y;

                        if (newY < 0 || newY > 8)
                            break;

                        if (possMas.Read(newX, newY * 2) == '\0')
                        {
                            WriteLinePoss1(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else if (possMas.Read(newX, newY * 2) == '2')
                        {
                            WriteLinePoss2(newX, newY * 2, '2');
                            possMas.Write(newX, newY * 2, '2');
                        }
                        else
                        {
                            break;
                        }
                    }
                }




            }
            else if (s == 'B')
            {
                for (int x = -1; x <= 1; x += 2)
                {
                    for (int y = -1; y <= 1; y += 2)
                    {
                        int newX = i;
                        int newY = j;

                        while (true)
                        {
                            newX += x;
                            newY += y;

                            if (newX < 0 || newX > 8 || newY < 0 || newY > 8)
                                break;

                            if (possMas.Read(newX, newY * 2) == '\0')
                            {
                                WriteLinePoss1(newX, newY * 2, '2');
                                possMas.Write(newX, newY * 2, '2');
                            }
                            else if (possMas.Read(newX, newY * 2) == '2')
                            {
                                WriteLinePoss2(newX, newY * 2, '2');
                                possMas.Write(newX, newY * 2, '2');
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    Console.SetCursorPosition(0, 12);
}


void KnightCheck()
{

    bool b = true;
    while (b == true)
    {
        int x = 0;
        int y = 0;
        int x1 = 0;
        int y1 = 0;
        Console.SetCursorPosition(30, 2);
        Console.WriteLine("                                                                      ");
        Console.SetCursorPosition(30, 3);
        Console.WriteLine("                                                                      ");
        Console.SetCursorPosition(30, 2);
        Console.WriteLine("Insert Possition(A8,B4,C3....)");
        Console.SetCursorPosition(30, 3);
        Console.WriteLine("Insert NEXT Possition(A8,B4,C3....)");
        Console.SetCursorPosition(65, 2);
        String a1 = Console.ReadLine();
        Console.SetCursorPosition(65, 3);
        String a2 = Console.ReadLine();
        if (Check(a1, "N"))
        {
            PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), p1.Y.ToString());
            y = (char)((int)myEnumValue - 63);
            y = y / 2;
            x = p1.X;


        }
        else b = false;
        if (Check(a2, "N") && b == true)
        {
            x1 = p1.X;
            PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), p1.Y.ToString());
            y1 = (char)((int)myEnumValue - 63);
            y1 = y1 / 2;
            MinMoves(x - 1, y - 1, x1 - 1, y1 - 1);
            b = false;
        }
    }
}

void start()
{
    while (true)
    {
        Console.SetCursorPosition(0, 9);
        Console.WriteLine("Insert Possition(A8,B4,C3....)");
        Console.SetCursorPosition(0, 10);
        Console.WriteLine("Insert Figure(K,Q,B,N,R)");
        int poss = 9;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(30, poss);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(30, poss + 1);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(30, poss);
        string s1 = Console.ReadLine();
        Console.SetCursorPosition(0, 11);
        Console.WriteLine("                          ");
        Console.SetCursorPosition(30, poss + 1);
        string s3 = Console.ReadLine();
        bool b = CheckPoss(s1, s3);
        if (b == true)
        {
            break;
        }
    }

    Console.SetCursorPosition(30, 0);
    Console.Write("Insert NEXT Possition(A8,B4,C3....)");
    string a1 = Console.ReadLine();
    Console.SetCursorPosition(30, 1);
    Console.Write("Insert Figure(K,Q,B,N,R)");
    string c1 = Console.ReadLine();
    Console.SetCursorPosition(30, 30);
    int x1 = p1.X;
    char y1 = p1.Y;
    void King()
    {
        if (Check(a1, c1) && ((Math.Abs(x1 - p1.X) == 1 && Math.Abs(y1 - p1.Y) == 0) || (Math.Abs(x1 - p1.X) == 0 && Math.Abs(y1 - p1.Y) == 1) || (Math.Abs(x1 - p1.X) == 1 && Math.Abs(y1 - p1.Y) == 1))
        )
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }
    }


    void Queen()
    {
        if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == 0 && Math.Abs(y1 - p1.Y) != 0) || (Math.Abs(x1 - p1.X) != 0 && Math.Abs(y1 - p1.Y) == 0))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == Math.Abs(y1 - p1.Y)))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }
    }
    void Rook()
    {
        if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == 0 && Math.Abs(y1 - p1.Y) != 0) || (Math.Abs(x1 - p1.X) != 0 && Math.Abs(y1 - p1.Y) == 0))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }
    }



    void Bishop()
    {
        if (Check(a1, c1) && (Math.Abs(x1 - p1.X) == Math.Abs(y1 - p1.Y)))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }

    }

    void Knight()
    {
        if (Check(a1, c1) && ((Math.Abs(p1.X - x1) == 1 && Math.Abs(p1.Y - y1) == 2) || (Math.Abs(p1.X - x1) == 2 && Math.Abs(p1.Y - y1) == 1)))
        {
            CheckPoss(a1, c1);
            Move();
            Console.SetCursorPosition(0, 14);
        }
        else
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Incorrect Figure or possition");
        }

    }
    void Move()
    {
        Thread.Sleep(1000);
        WriteLinePossition(x1, y1, ' ');
    }
    switch (c1)
    {
        case "K":
            King();
            break;
        case "Q":
            Queen();
            break;
        case "B":
            Bishop();
            break;
        case "N":
            Knight();
            break;
        case "R":
            Rook();
            break;
        default:
            break;
    }
}

bool Check(string s1, string s3)
{
    string letters = "";
    string numbers = "";
    foreach (char c in s1)
    {
        if (char.IsLetter(c))
        {
            letters += c;
        }
        else if (char.IsDigit(c))
        {
            numbers += c;
        }
    }
    bool b = false;
    if (int.TryParse(numbers, out int result1) && char.TryParse(letters, out char result2) && char.TryParse(s3, out char result3))
    {

        foreach (Figures figure in Enum.GetValues(typeof(Figures)))
        {


            if (figure.ToString()[0] == result3)
            {
                b = true;
            }

        }
        if (result1 >= 1 && result1 < 9 && result2 >= 'A' && result2 <= 'H' && b == true)
        {
            p1 = new Possition(result1, result2, result3);


        }
        else
        {
            Console.SetCursorPosition(15, 0);
            Console.WriteLine("Insert true data");
            b = false;

        }
    }
    return b;
}

bool CheckPoss(string s1, string s3)
{
    bool b = false;
    string letters = "";
    string numbers = "";

    foreach (char c in s1)
    {
        if (char.IsLetter(c))
        {
            letters += c;
        }
        else if (char.IsDigit(c))
        {
            numbers += c;
        }
    }
    if (int.TryParse(numbers, out int result1) && char.TryParse(letters, out char result2) && char.TryParse(s3, out char result3))
    {
        char y2;
        foreach (Figures figure in Enum.GetValues(typeof(Figures)))
        {


            if (figure.ToString()[0] == result3)
            {
                b = true;
            }

        }
        if (result1 >= 1 && result1 < 9 && result2 >= 'A' && result2 <= 'H' && b == true)
        {
            int a;
            p1 = new Possition(result1, result2, result3);
            WriteLinePossition(p1.X, p1.Y, p1.Letter);
            y2 = p1.Y;
            PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), y2.ToString());
            y2 = (char)((int)myEnumValue - 63);
            a = y2;
            possMas.Write(p1.X, a, p1.Letter);

        }
        else
        {
            Console.WriteLine("Insert true data");
            b = false;

        }
    }
    return b;
}

void WriteLinePossition(int X, char Y, char Letter)
{
    p1.X = X;
    p1.Y = Y;
    p1.Letter = Letter;
    int x1 = 8 - X;
    char y1 = Y;
    PossY myEnumValue = (PossY)Enum.Parse(typeof(PossY), y1.ToString());
    y1 = (char)((int)myEnumValue - 63);
    PossY poss;

    Console.SetCursorPosition(y1, x1);
    if ((Y == 'A' || Y == 'C' || Y == 'E' || Y == 'G') && (x1 % 2 == 0))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else if ((Y == 'B' || Y == 'D' || Y == 'F' || Y == 'H') && (x1 % 2 == 1))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

}
void WriteLinePoss(int X, int Y, char Letter)
{
    X = 7 - X;
    int y = Y + Y + 2;
    Console.SetCursorPosition(y, X);
    if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

}
void WriteLinePoss1(int X, int Y, char Letter)
{
    X = 8 - X;
    int y = Y;
    Console.SetCursorPosition(y, X);
    if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Letter);
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

}
void WriteLinePoss2(int X, int Y, char Letter)
{
    X = 8 - X;
    int y = Y;
    Console.SetCursorPosition(y, X);
    if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Letter);
    }
    else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Letter);
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Letter);
    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

}

void CreateСhessBoard()
{
    Console.SetCursorPosition(0, 0);

    for (int i = 8; i > 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.Write(" ");

    for (char symbol = 'A'; symbol <= 'H'; symbol++)
    {
        Console.Write(symbol + " ");


    }
    Console.SetCursorPosition(1, 0);
    int y = 1;
    for (int i = 8; i > 0; i--)
    {

        for (int j = 1; j < 9; j++)
        {

            if ((i + j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
                Console.Write(" ");
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.Write(" ");

            }
        }
        Console.SetCursorPosition(1, y);
        y++;

    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("");

}

void MinMoves(int startX, int startY, int endX, int endY)
{
    int[] x = { 1, 1, 2, 2, -1, -1, -2, -2 };
    int[] y = { 2, -2, 1, -1, 2, -2, 1, -1 };

    bool[,] visited = new bool[8, 8];
    Point[] points = new Point[64];
    int check = 0, move = 0;

    points[move++] = new Point { X = startX, Y = startY, Moves = 0 };
    visited[startX, startY] = true;

    while (check < move)
    {
        var point = points[check++];

        if (point.X == endX && point.Y == endY)
        {
            CanReach(startX, startY, endX, endY, point.Moves);
            Console.SetCursorPosition(15, 15);
        }
        for (int i = 0; i < 8; i++)
        {
            int newX = point.X + x[i];
            int newY = point.Y + y[i];

            if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8 && !visited[newX, newY])
            {
                points[move++] = new Point { X = newX, Y = newY, Moves = point.Moves + 1 };
                visited[newX, newY] = true;

            }
        }
    }

}
void CanReach(int startX, int startY, int endX, int endY, int hops)
{
    bool t = true;
    int[] x = { -2, -1, 1, 2, 2, 1, -1, -2 };
    int[] y = { 1, 2, 2, 1, -1, -2, -2, -1 };

    List<Tuple<int, int>> path = new List<Tuple<int, int>>();
    path.Add(new Tuple<int, int>(startX, startY));
    while (t == true)
    {
        if (CanReachInNHops(startX, startY, endX, endY, hops, path))
        {
            Console.SetCursorPosition(0, 10);
            Console.WriteLine($"Hops = {hops} ");
            char a = '0';
            foreach (var move in path)
            {

                if (path.Count > 0)
                {
                    WriteLinePoss(move.Item1, move.Item2, a);
                    a++;
                }
                var lastMove = path[path.Count - 1];
                WriteLinePoss(lastMove.Item1, lastMove.Item2, 'N');
                t = false;
            }
        }
        else hops++;

    }

    bool IsValid(int x, int y)
    {
        return x >= 0 && x < 8 && y >= 0 && y < 8;
    }

    bool CanReachInNHops(int startX, int startY, int endX, int endY, int remainingHops, List<Tuple<int, int>> path)
    {
        if (remainingHops == 0)
        {
            return startX == endX && startY == endY;
        }

        for (int i = 0; i < 8; i++)
        {
            int newX = startX + x[i];
            int newY = startY + y[i];

            if (IsValid(newX, newY))
            {
                path.Add(new Tuple<int, int>(newX, newY));

                if (CanReachInNHops(newX, newY, endX, endY, remainingHops - 1, path))
                {
                    return true;
                }

                path.RemoveAt(path.Count - 1);
            }
        }
        return false;
    }

}
