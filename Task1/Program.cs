int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        Console.WriteLine($"Порядковый номер нечетного элемента {array[i]}: {i + 1}");
    }
}