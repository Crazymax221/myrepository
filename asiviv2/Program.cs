
//1.
Random rand = new Random();

int[] arr = new int[10];

int ss = int.MinValue;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(1, 100);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > ss)
    {
        ss = arr[i];
        
    }
   
}

 Console.WriteLine($"largest is --> {ss}");

int largest = int.MinValue;
int secondLargest = int.MinValue;

foreach (int nummm in arr)
{
    if (nummm > largest)
    {
        secondLargest = largest;
        largest = nummm;
    }
    else if (nummm > secondLargest && nummm < largest)
    {
        secondLargest = nummm;

    }
     
}

Console.WriteLine($"second largetst is --> {secondLargest}");

//2.

int[,] array = new int[3, 3]
{
    { 5, 9, 8 },
    { 1, 4, 6 },
    { 7, 3, 2 }
};

int rows = array.GetLength(0);
int cols = array.GetLength(1);
int[] tempArray = new int[rows * cols];
int index = 0;

Console.WriteLine("array before");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("----");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        tempArray[index++] = array[i, j];
    }
}

Array.Sort(tempArray);

int numm = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = tempArray[numm++];
    }
}

Console.WriteLine("array after");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

//3.

List<int> list = new List<int> { 10, 20, 30, 40, 50 };

Console.WriteLine($"start index:{list[0]} , {list[1]} ,{list[2]} ,{list[3]} ,{list[4]} ,");

numm = 2; //<-- select index that needes to be removed

list.RemoveAt(numm);

Console.Write("\nlist after:");
foreach (int n in list)
{
    
    Console.Write(n + ", ");
}


//4

int[,] mt = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int ans = 0;

Console.WriteLine($"\n {mt[0, 0]}{mt[0, 1]}{mt[0,2]} \n {mt[1, 0]}{mt[1, 1]}{mt[1, 2]} \n {mt[2, 0]}{mt[2, 1]}{mt[2, 2]}");

Console.WriteLine("\nenter the coluumm");
int col = Convert.ToInt32(Console.ReadLine());

col--;
for (int i = 0; i < mt.GetLength(0); ++i)
{
    ans = ans + mt[col, i];
}
col++;
Console.WriteLine($"the total for all elements in col {col} is {ans}");

