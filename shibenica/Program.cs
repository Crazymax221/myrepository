
Random rand = new Random();

HashSet<char> guessedLetters = new HashSet<char>();
string[] words = new string[] { "car", "apple", "deer", "hamster", "minecraft", "samsung" };
int randword = rand.Next(words.Length);
string word = words[randword];

int letters = word.Length;
int mistakes = 0;


while (mistakes < letters)
{

    string displayWord = "";
    foreach (char c in word)
    {

        displayWord += guessedLetters.Contains(c) ? c + " " : "_ ";

    }
    Console.WriteLine("\nword: " + displayWord);

if (!displayWord.Contains("_"))
{
    Console.WriteLine("\nyou guessed the word");
    break;
}

    Console.Write("enter a char: ");
    char guess = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (guessedLetters.Contains(guess))
    {
        Console.Clear();
        Console.WriteLine("you already use this letter, use other");
        continue;
    }
    Console.Clear();
    Console.WriteLine("you guessed correct leter");
    guessedLetters.Add(guess);

    if (!word.Contains(guess))
    {
        Console.Clear();
        mistakes++;
        Console.WriteLine($"fail, try left: {letters - mistakes}");
    }
    if (mistakes == letters)
    {
        Console.Clear();
        Console.WriteLine("\nyou loose, the secred word is --> " + word);
    }
}

//:)
