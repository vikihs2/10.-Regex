using System.Collections.Generic;
Dictionary<string, double> gearPrices = new Dictionary<string, double>();
double totalCost = 0;
while (true)
{
    string input = Console.ReadLine();
    if (input == "Run!")
    {
        break;
    }
    if (IsValidInput(input))
    {
        string[] tokens = input.Split(new[] { '<', '>', '=', '-', '-' }, StringSplitOptions.RemoveEmptyEntries);
        string gearName = tokens[0];
        int quantity = int.Parse(tokens[1]);
        double price = double.Parse(tokens[2]);
        double gearTotalCost = quantity * price;
        totalCost += gearTotalCost;
        gearPrices[gearName] = gearTotalCost;
    }
}
foreach (var gear in gearPrices.Keys)
{
    Console.WriteLine(gear);
}
Console.WriteLine($"Total cost: {totalCost:F2}");
static bool IsValidInput(string input)
{
    return input.StartsWith("<>") && input.Contains("<>") && input.Contains("--");
}