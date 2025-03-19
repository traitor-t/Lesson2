string mainString = "Hello, world!";
string subString = "world";

int index = FindFirstIndexOfSubstring(mainString, subString);

if (index != -1)
{
    Console.WriteLine($"Первое вхождение подстроки \"{subString}\" найдено по индексу: {index}");
}
else
{
    Console.WriteLine($"Подстрока \"{subString}\" не найдена в строке.");
}
static int FindFirstIndexOfSubstring(string mainString, string subString)
{
    return mainString.IndexOf(subString);
}
