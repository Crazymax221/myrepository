
//masiv

//int[] makakas = new int[5] {1,2,3,4,5};

//foreach ( int makaka in makakas)
//{
//    Console.WriteLine(makaka);
//}

////masiv 2d

//int[,] myboard = new int[3, 3];
//myboard[0, 0] = 1;
//myboard[0, 1] = 2;
//myboard[0, 2] = 3;
//myboard[1, 0] = 4;
//myboard[1, 1] = 5;
//myboard[1, 2] = 6;
//myboard[2, 0] = 7;
//myboard[2, 1] = 8;
//myboard[2, 2] = 9;

//for (int i = 0; i < myboard.GetLength(0); i++)
//{
//    for (int j = 0; j < myboard.GetLength(1); j++)
//    {
//        Console.Write(myboard[i, j] + " ");
//    }
//}

//masiv v masive

//int[][] masivv = new int[3][]
//{
//    [1,2,3],
//    [4,5,6],
//    [7,8,9]
//};

//for (int i = 0; i < masivv.GetLength(0); i++)
//{
//    for (int j = 0; j < masivv[i].Length; j++)
//    {
//        Console.Write(masivv[i][j] + " ");
//    } 
//}

//enum

//Console.WriteLine("Enter a day of the week:");
//if(int.TryParse(Console.ReadLine(), out int day) && day !=0 )
//    {
//    day dayres = (day)(day%7);
//    Console.WriteLine($"day is {dayres}");
//}



//enum day
//{
//    dayyy,
//    Monday ,
//    Tuesday ,
//    Wednesday  ,
//    Thursday  ,
//    Friday  ,
//    Saturday  ,
//    Sunday 
//}


// list

//List<string> game = new List<string>();

//game.Add("GTA");
//game.Add("CS");

//game.AddRange(["minecraft", "lol"]);

//Console.WriteLine(game[0]);

//game.RemoveAt(0);

//Console.WriteLine(game[0]);

//game.Insert(3, "gta");
int[,] multiplicationTable = new int[9, 9];

// Заповнення таблиці множення
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}

// Виведення таблиці множення
Console.WriteLine("Таблиця множення:");
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(multiplicationTable[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}