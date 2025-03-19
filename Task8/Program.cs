using System.Text;

string input = "AbCdIfJ";
string snakeCase = ConvertToSnakeCase(input);
Console.WriteLine(snakeCase);
static string ConvertToSnakeCase(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return input;
    }

    StringBuilder result = new StringBuilder();
    result.Append(char.ToLower(input[0]));

    for (int i = 1; i < input.Length; i++)
    {
        if (char.IsUpper(input[i]))
        {
            result.Append('_');
            result.Append(char.ToLower(input[i]));
        }
        else
        {
            result.Append(input[i]);
        }
    }

    return result.ToString();
}