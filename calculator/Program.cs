
Console.WriteLine("write first number");
int? num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("choose: 1; + , 2; - , 3; * , 4; /");
int cc = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write second number number");
int? num2 = Convert.ToInt32(Console.ReadLine());

int ans;
try
{
if (cc == 1)
{
    ans = (int)(num1 + num2);
    Console.WriteLine(ans);
}
else if (cc == 2)
{
    ans = (int)(num1 - num2);
    Console.WriteLine(ans);
}
else if (cc == 3)
{
    ans = (int)(num1 * num2);
    Console.WriteLine(ans);
}
else if (cc == 4)
{
    ans = (int)(num1 / num2);
    Console.WriteLine(ans);
}
}
catch (DivideByZeroException)
{
    Console.WriteLine("cant divide by 0");
}

