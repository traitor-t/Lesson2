string input = "aaabbbcccccddeeeee";
FindLongestSequence(input);
static void FindLongestSequence(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Строка пуста.");
        return;
    }

    char currentChar = input[0];
    int currentLength = 1;
    char maxChar = currentChar;
    int maxLength = currentLength;

    for (int i = 1; i < input.Length; i++)
    {
        if (input[i] == currentChar)
        {
            currentLength++;
        }
        else
        {
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxChar = currentChar;
            }
            currentChar = input[i];
            currentLength = 1;
        }
    }

    if (currentLength > maxLength)
    {
        maxLength = currentLength;
        maxChar = currentChar;
    }

    Console.WriteLine($"Самая длинная последовательность: символ '{maxChar}', длина {maxLength}");
}