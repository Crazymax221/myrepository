
//1.

Random rand = new Random();
int[] num = new int[10];

for (int i = 0; i < num.Length; i++)
{
    num[i] = rand.Next(-10, 10);
}

Console.WriteLine("elements with same index:");
for (int i = 0; i < num.Length; i += 2)
{
    Console.WriteLine(num[i]);
}

//2.

int numm = 0;

foreach (int n in num)
{
    numm += n;
}
Console.WriteLine($"sum of all elements is {numm}");

if (numm >= 0 )
{
    Console.WriteLine("positive");
}
else
{
    Console.WriteLine("negative");
}

//3.

int[,] table = new int[9, 9];

for (int a = 0; a < 9; a++)
{
    for (int b = 0; b < 9; b++)
    {
        table[a, b] = (a + 1) * (b + 1);
    }
}

Console.WriteLine("multiplication table:");
for (int a = 0; a < 9; a++)
{
    for (int b = 0; b < 9; b++)
    {
        Console.Write(table[a, b] + " ");
    }
    Console.WriteLine();
}

//4.

int[,] myboard = new int[5, 5];

int maxElement = int.MinValue;
int minElement = int.MaxValue;
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;

for (int g = 0; g < 5; g++)
{
    for (int h = 0; h < 5; h++)
    {
        myboard[g, h] = rand.Next(-100, 100);
        if (myboard[g, h] > maxElement)
        {
            maxElement = myboard[g, h];
            maxRow = g;
            maxCol = h;
        }

        if (myboard[g, h] < minElement)
        {
            minElement = myboard[g, h];
            minRow = g;
            minCol = h;
        }
    }
}
Console.WriteLine($"maximum element: {maxElement} (row: {maxRow}, coluum: {maxCol})");
Console.WriteLine($"minimum element: {minElement} (row: {minRow}, coluum: {minCol})");


//5.

Console.WriteLine("Enter a day of the week:");
if (int.TryParse(Console.ReadLine(), out int day) && day != 0)
{
    day dayres = (day)(day % 7);
    Console.WriteLine($"day is {dayres}");
}



enum day
{
    dayyy,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
