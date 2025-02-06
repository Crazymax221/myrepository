
string num;
int result;

Console.WriteLine("enter number");
num = Console.ReadLine();

if (int.TryParse(num, out result))
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("write only number number");
}