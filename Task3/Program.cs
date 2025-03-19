Console.WriteLine("Введите размер матрицы N (N < 10): ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 10)
{
    Console.WriteLine("Ошибка: N должно быть меньше 10");
    return;
}

Console.WriteLine("Введите нижний предел диапазона a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел диапазона b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижний предел промежутка C: ");
int C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел промежутка D: ");
int D = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[N,N];
Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix[i,j] = rnd.Next(a, b + 1);
    }
}

Console.WriteLine("\nИсходная матрица:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

long product = 1;
bool hasElementsInRange = false;

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (matrix[i, j] >= C && matrix[i, j] <= D)
        {
            product *= matrix[i, j];
            hasElementsInRange = true;
        }
    }
}

if (!hasElementsInRange)
    product = 0;

Console.WriteLine($"Произведение чисел в промежутке [{C}, {D}]: {product}");

Console.WriteLine("Суммы элементов каждого столбца:");
for (int j = 0; j < N; j++)
{
    int columnSum = 0;

    for (int i = 0; i < N; i++)
    {
        columnSum += matrix[i, j];
        
    }
    Console.WriteLine($"Сумма столбца {j + 1}: {columnSum}");
}