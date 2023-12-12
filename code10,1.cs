using System.Text.RegularExpressions;
string input = Console.ReadLine();
Regex metalRegex = new Regex(@"@(\w+)\|");
Regex gemRegex = new Regex(@"#(\w+)\*");
Match metalMatch = metalRegex.Match(input);
Match gemMatch = gemRegex.Match(input);
string metal = metalMatch.Success ? metalMatch.Groups[1].Value : "no metal";
string gem = gemMatch.Success ? gemMatch.Groups[1].Value : "no gem";
Console.WriteLine($"Found hidden {metal} and {gem} in the cave.");