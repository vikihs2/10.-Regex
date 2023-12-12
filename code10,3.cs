using System.Text.RegularExpressions;

string[] heroes = Console.ReadLine().Split(", ");

Dictionary<string, int> heroVotes = new Dictionary<string, int>();

string input;
while ((input = Console.ReadLine()) != "end")
{
    foreach (var hero in heroes)
    {
        string pattern = $@"[^a-zA-Z]*({hero})[^a-zA-Z]*(\d+)[^a-zA-Z]*";
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            int points = int.Parse(match.Groups[2].Value);

            if (heroVotes.ContainsKey(hero))
            {
                heroVotes[hero] += points;
            }
            else
            {
                heroVotes.Add(hero, points);
            }
        }
    }
}

var top3Heroes = heroVotes.OrderByDescending(kv => kv.Value).Take(3).Select(kv => kv.Key);

Console.WriteLine(string.Join(Environment.NewLine, top3Heroes));