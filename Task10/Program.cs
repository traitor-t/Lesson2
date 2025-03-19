using System.Text.RegularExpressions;

string input = "Сегодня 19.03.2025, а завтра будет 20.03.2025";
List<string> dates = FindDates(input);

Console.WriteLine("Найденные даты:");
foreach (string date in dates)
{
    Console.WriteLine(date);
}

    static List<string> FindDates(string input)
{
    List<string> dates = new List<string>();

    string pattern = @"\b\d{2}\.\d{2}\.\d{4}\b";
    Regex regex = new Regex(pattern);


    MatchCollection matches = regex.Matches(input);


    foreach (Match match in matches)
    {
        dates.Add(match.Value);
    }

    return dates;
}