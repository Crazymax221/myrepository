
using System.Text;

StringBuilder report = new StringBuilder();
report.AppendLine("Event report");
report.AppendLine("--------------------------");

Console.WriteLine("write the events (to finish write end 'end'):");

while (true)
{
    Console.Write("event: ");
    string input = Console.ReadLine();

    if (input.Equals("end", StringComparison.OrdinalIgnoreCase))
        break;

    report.AppendLine("- " + input);
}

report.AppendLine("--------------------------");
Console.WriteLine("\nfinished report:");
Console.WriteLine(report.ToString());