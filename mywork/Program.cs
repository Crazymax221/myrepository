

bool pl1 = true;
bool pl2 = false;
bool gameend = false;

string[] noms = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool[] wincombpl1 = { false, false, false, false, false, false, false, false, false, false };
bool[] wincombpl2 = { false, false, false, false, false, false, false, false, false, false };
Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
    $"{noms[7]}|{noms[8]}|{noms[9]}");
while (gameend == false)
{
    if (pl1)
    {
        Console.WriteLine("player 1 your turn");
        int ans = Convert.ToInt32(Console.ReadLine());

        switch (ans)
        {
            case 1:
                noms[1] = "X";
                Console.Clear();
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[1] = true;
                wincombpl2[1] = false;
                break;
            case 2:
                Console.Clear();
                noms[2] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[2] = true;
                wincombpl2[2] = false;
                break;
            case 3:
                Console.Clear();
                noms[3] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[3] = true;
                wincombpl2[3] = false;
                break;
            case 4:
                Console.Clear();
                noms[4] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[4] = true;
                wincombpl2[4] = false;
                break;
            case 5:
                Console.Clear();
                noms[5] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[5] = true;
                wincombpl2[5] = false;
                break;
            case 6:
                Console.Clear();
                noms[6] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[6] = true;
                wincombpl2[6] = false;
                break;
            case 7:
                Console.Clear();
                noms[7] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[7] = true;
                wincombpl2[7] = false;
                break;
            case 8:
                Console.Clear();
                noms[8] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[8] = true;
                wincombpl2[8] = false;
                break;
            case 9:
                Console.Clear();
                noms[9] = "X";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl1[9] = true;
                wincombpl2[9] = false;
                break;
        }
        pl1 = false;
        pl2 = true;
        if (wincombpl1[1] && wincombpl1[2] && wincombpl1[3] == true ||
    wincombpl1[4] && wincombpl1[5] && wincombpl1[6] == true ||
    wincombpl1[7] && wincombpl1[8] && wincombpl1[9] == true ||
    wincombpl1[1] && wincombpl1[4] && wincombpl1[7] == true ||
    wincombpl1[2] && wincombpl1[5] && wincombpl1[8] == true ||
    wincombpl1[3] && wincombpl1[6] && wincombpl1[9] == true ||
    wincombpl1[1] && wincombpl1[5] && wincombpl1[9] == true ||
    wincombpl1[3] && wincombpl1[5] && wincombpl1[7] == true)
        {
            gameend = true;
            break;

        }
    }

    if (pl2)
    {
        Console.WriteLine("player 2 your turn");
        int ans = Convert.ToInt32(Console.ReadLine());

        switch (ans)
        {
            case 1:
                Console.Clear();
                noms[1] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[1] = true;
                wincombpl1[1] = false;
                break;
            case 2:
                Console.Clear();
                noms[2] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[2] = true;
                wincombpl1[1] = false;
                break;
            case 3:
                Console.Clear();
                noms[3] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[3] = true;
                wincombpl1[1] = false;
                break;
            case 4:
                Console.Clear();
                noms[4] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[4] = true;
                wincombpl1[1] = false;
                break;
            case 5:
                Console.Clear();
                noms[5] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[5] = true;
                wincombpl1[1] = false;
                break;
            case 6:
                Console.Clear();
                noms[6] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[6] = true;
                wincombpl1[1] = false;
                break;
            case 7:
                Console.Clear();
                noms[7] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[7] = true;
                wincombpl1[1] = false;
                break;
            case 8:
                Console.Clear();
                noms[8] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[8] = true;
                wincombpl1[1] = false;
                break;
            case 9:
                Console.Clear();
                noms[9] = "O";
                Console.WriteLine($"{noms[1]}|{noms[2]}|{noms[3]}\n" +
                    $"{noms[4]}|{noms[5]}|{noms[6]}\n" +
                    $"{noms[7]}|{noms[8]}|{noms[9]}");
                wincombpl2[9] = true;
                wincombpl1[1] = false;
                break;
        }
        pl2 = false;
        pl1 = true;
        if (wincombpl2[1] && wincombpl2[2] && wincombpl2[3] == true ||
    wincombpl2[4] && wincombpl2[5] && wincombpl2[6] == true ||
    wincombpl2[7] && wincombpl2[8] && wincombpl2[9] == true ||
    wincombpl2[1] && wincombpl2[4] && wincombpl2[7] == true ||
    wincombpl2[2] && wincombpl2[5] && wincombpl2[8] == true ||
    wincombpl2[3] && wincombpl2[6] && wincombpl2[9] == true ||
    wincombpl2[1] && wincombpl2[5] && wincombpl2[9] == true ||
    wincombpl2[3] && wincombpl2[5] && wincombpl2[7] == true)
        {
            gameend = true;
            break;

        }

        else if (noms[noms.Length - 1] == "X" || noms[noms.Length - 1] == "O")
        {
            Console.WriteLine("draw");
            gameend = true;
            pl1 = false;
            pl2 = false;
        }

    }

}   
    
if (pl1)
    {
        Console.WriteLine("player 2 wins");
    }
    else if (pl2)
    {
        Console.WriteLine("player 1 wins");
    }
    else if (gameend == true)
{
        Console.WriteLine("draw");
    }

