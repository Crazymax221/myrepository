
string[,] board = new string[3, 3];
int[,] boardnum = new int[3, 3];
bool[,] wincomb = new bool[3, 3];
bool[,] wincomb1 = new bool[3, 3];

bool isPlayer1 = true;
bool isPlayer2 = false;
bool gameover = true;
int nummm = 0; 

board[0, 0] = "1";
board[0, 1] = "2";
board[0, 2] = "3";
board[1, 0] = "4";
board[1, 1] = "5";
board[1, 2] = "6";
board[2, 0] = "7";
board[2, 1] = "8";
board[2, 2] = "9";



while (gameover)
{
    if (isPlayer1)
    {
        Console.WriteLine($"  {board[0, 0]} | {board[0, 1]} | {board[0, 2]} \n -----------" +
         $" \n  {board[1, 0]} | {board[1, 1]} | {board[1, 2]} \n -----------" +
         $" \n  {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");

        Console.WriteLine("Player 1, enter a number");
        int.TryParse(Console.ReadLine(), out int num);
        if (num == boardnum[0, 0] ||
            num == boardnum[0, 1] ||
            num == boardnum[0, 2] ||
            num == boardnum[1, 0] ||
            num == boardnum[1, 1] ||
            num == boardnum[1, 2] ||
            num == boardnum[2, 0] ||
            num == boardnum[2, 1] ||
            num == boardnum[2, 2])
        {
            Console.Clear();
            Console.WriteLine("This number is already taken");

        }
        else
        {
            Console.Clear();
            switch (num)
            {
                case 1:
                    board[0, 0] = "X";
                    boardnum[0, 0] = 1;
                    nummm++;
                    wincomb[0, 0] = true;
                    Console.Clear();
                    break;
                case 2:
                    board[0, 1] = "X";
                    boardnum[0, 1] = 2;
                    nummm++;
                    wincomb[0, 1] = true;
                    Console.Clear();
                    break;
                case 3:
                    board[0, 2] = "X";
                    boardnum[0, 2] = 3;
                    nummm++;
                    wincomb[0, 2] = true;
                    Console.Clear();
                    break;
                case 4:
                    board[1, 0] = "X";
                    boardnum[1, 0] = 4;
                    nummm++;
                    wincomb[1, 0] = true;
                    Console.Clear();
                    break;
                case 5:
                    board[1, 1] = "X";
                    boardnum[1, 1] = 5;
                    nummm++;
                    wincomb[1, 1] = true;
                    Console.Clear();
                    break;
                case 6:
                    board[1, 2] = "X";
                    boardnum[1, 2] = 6;
                    nummm++;
                    wincomb[1, 2] = true;
                    Console.Clear();
                    break;
                case 7:
                    board[2, 0] = "X";
                    boardnum[2, 0] = 7;
                    nummm++;
                    wincomb[2, 0] = true;
                    Console.Clear();
                    break;
                case 8:
                    board[2, 1] = "X";
                    boardnum[2, 1] = 8;
                    nummm++;
                    wincomb[2, 1] = true;
                    Console.Clear();
                    break;
                case 9:
                    board[2, 2] = "X";
                    boardnum[2, 2] = 9;
                    nummm++;
                    wincomb[2, 2] = true;
                    Console.Clear();
                    break;

            }
            isPlayer1 = false;
            isPlayer2 = true;

        }
    }

    if (nummm == 9)
    {
        gameover = false;
    }
    else if (wincomb[0, 0] && wincomb[0, 1] && wincomb[0, 2] ||
        wincomb[1, 0] && wincomb[1, 1] && wincomb[1, 2] ||
        wincomb[2, 0] && wincomb[2, 1] && wincomb[2, 2] ||
        wincomb[0, 0] && wincomb[1, 0] && wincomb[2, 0] ||
        wincomb[0, 1] && wincomb[1, 1] && wincomb[2, 1] ||
        wincomb[0, 2] && wincomb[1, 2] && wincomb[2, 2] ||
        wincomb[0, 0] && wincomb[1, 1] && wincomb[2, 2] ||
        wincomb[0, 2] && wincomb[1, 1] && wincomb[2, 0])
    {
        gameover = false;
        isPlayer1 = true;
        isPlayer2 = false;
    }

    if (isPlayer2)
    {

        Console.WriteLine($"  {board[0, 0]} | {board[0, 1]} | {board[0, 2]} \n -----------" +
    $" \n  {board[1, 0]} | {board[1, 1]} | {board[1, 2]} \n -----------" +
    $" \n  {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");

        Console.WriteLine("Player 2, enter a number");
        int.TryParse(Console.ReadLine(), out int num);
        if (num == boardnum[0, 0] ||
            num == boardnum[0, 1] ||
            num == boardnum[0, 2] ||
            num == boardnum[1, 0] ||
            num == boardnum[1, 1] ||
            num == boardnum[1, 2] ||
            num == boardnum[2, 0] ||
            num == boardnum[2, 1] ||
            num == boardnum[2, 2])
        {
            Console.Clear();
            Console.WriteLine("This number is already taken");
        }
        else
        {

            switch (num)
            {
                case 1:
                    board[0, 0] = "O";
                    boardnum[0, 0] = 1;
                    nummm++;
                    wincomb1[0, 0] = true;
                    Console.Clear();
                    break;
                case 2:
                    board[0, 1] = "O";
                    boardnum[0, 1] = 2;
                    nummm++;
                    wincomb1[0, 1] = true;
                    Console.Clear();
                    break;
                case 3:
                    board[0, 2] = "O";
                    boardnum[0, 2] = 3;
                    nummm++;
                    wincomb1[0, 2] = true;
                    Console.Clear();
                    break;
                case 4:
                    board[1, 0] = "O";
                    boardnum[1, 0] = 4;
                    nummm++;
                    wincomb1[1, 0] = true;
                    Console.Clear();
                    break;
                case 5:
                    board[1, 1] = "O";
                    boardnum[1, 1] = 5;
                    nummm++;
                    wincomb1[1, 1] = true;
                    Console.Clear();
                    break;
                case 6:
                    board[1, 2] = "O";
                    boardnum[1, 2] = 6;
                    nummm++;
                    wincomb1[1, 2] = true;
                    Console.Clear();
                    break;
                case 7:
                    board[2, 0] = "O";
                    boardnum[2, 0] = 7;
                    nummm++;
                    wincomb1[2, 0] = true;
                    Console.Clear();
                    break;
                case 8:
                    board[2, 1] = "O";
                    boardnum[2, 1] = 8;
                    nummm++;
                    wincomb1[2, 1] = true;
                    Console.Clear();
                    break;
                case 9:
                    board[2, 2] = "O";
                    boardnum[2, 2] = 9;
                    nummm++;
                    wincomb1[2, 2] = true;
                    Console.Clear();
                    break;
            }
            Console.Clear();
            isPlayer1 = true;
            isPlayer2 = false;

        }
    }

    if (nummm == 9)
    {
        gameover = false;
    }
    else if (wincomb1[0, 0] && wincomb1[0, 1] && wincomb1[0, 2] ||
        wincomb1[1, 0] && wincomb1[1, 1] && wincomb1[1, 2] ||
        wincomb1[2, 0] && wincomb1[2, 1] && wincomb1[2, 2] ||
        wincomb1[0, 0] && wincomb1[1, 0] && wincomb1[2, 0] ||
        wincomb1[0, 1] && wincomb1[1, 1] && wincomb1[2, 1] ||
        wincomb1[0, 2] && wincomb1[1, 2] && wincomb1[2, 2] ||
        wincomb1[0, 0] && wincomb1[1, 1] && wincomb1[2, 2] ||
        wincomb1[0, 2] && wincomb1[1, 1] && wincomb1[2, 0])
    {
        gameover = false;
        isPlayer1 = false;
        isPlayer2 = true;
    }
}

Console.WriteLine($"  {board[0, 0]} | {board[0, 1]} | {board[0, 2]} \n -----------" +
$" \n  {board[1, 0]} | {board[1, 1]} | {board[1, 2]} \n -----------" +
$" \n  {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");

Console.WriteLine("Game over");

if (isPlayer1)
{
    Console.WriteLine("Player 1 wins");
}
else if (isPlayer2)
{
    Console.WriteLine("Player 2 wins");
}

//;)