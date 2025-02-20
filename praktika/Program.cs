
//1.Обчислення середнього заробітку:

Console.WriteLine("How much workers do you have paid?");
byte workers = Convert.ToByte(Console.ReadLine());

decimal salary = 0;

for (byte nun = 0; nun < workers; nun++)
{
    Console.WriteLine($"worker number {nun}");

    Console.WriteLine("write salary");
    salary += Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"money:{salary}");

}

Console.WriteLine($"average earnings is: {salary / workers}");

//2.Побудова графіку зірочками:

Console.Write("enter number: ");
if (int.TryParse(Console.ReadLine(), out int lines) && lines > 0)
{
    for (int ss = 1; ss <= lines; ss++)
    {
        Console.WriteLine(new string('*', ss));
    }
}

//4.Перевірка паролю:

Console.Write("enter pasword ");
string password = Console.ReadLine();

Console.WriteLine(IsValidPassword(password) ? "pasword accepted" : "pasword is invalid");

bool IsValidPassword(string password) //<< найшов в интернеті, не зовсім зрозумів, але працює.
{
    if (password.Length < 8)
        return false;

    bool digit = false;
    bool hspec = false;
    string spech = "!@#$%^&*(),.?\":{}|<>";

    foreach (char ch in password)
    {
        digit = char.IsDigit(ch) ? true : digit;
        hspec = spech.Contains(ch) ? true : hspec;

        if (digit && hspec)
            return true;
    }

    return false;
}


//5.Генерація фібоначчівської послідовності:


Console.Write("enter amount of numbers F: ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    long a = 0, b = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(a + " ");
        (a, b) = (b, a + b);
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("enter number");
}

//6.Калькулятор оплати праці за годину:

Console.WriteLine("how many houer you have work?");
decimal hours = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("how much you get payed per hour?");
decimal pay = Convert.ToDecimal(Console.ReadLine());

decimal sas = hours * pay;

Console.WriteLine(sas);

//7.Генерація таблиці множення для конкретного числа:


Console.WriteLine("enter number");
uint num = Convert.ToUInt32(Console.ReadLine());

for (uint ii = 0; ii <= 10; ii++)
{
    Console.WriteLine($"{num} * {ii} = {num * ii}");
}
