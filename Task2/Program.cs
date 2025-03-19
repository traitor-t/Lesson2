int[] array = new int[100];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-50,51);
}
Console.WriteLine("Отрицательные числа:");
foreach(var number in array)
{
    if (number < 0)
    {
        Console.WriteLine(number);
    }
}

Console.WriteLine("\nПоложительные числа:");
foreach (var number in array)
{
    if (number >= 0)
    {
        Console.WriteLine(number);
    }
}

Array.Sort(array);
Console.WriteLine("\nВведите число для поиска:");
int k = Convert.ToInt32(Console.ReadLine());

int index = Array.BinarySearch(array, k);
if (index >= 0)
{
    Console.WriteLine($"Число {k} найдено в массиве по индексу {index}");
}
else
{
    Console.WriteLine($"Число {k} не найдено в массиве");
}