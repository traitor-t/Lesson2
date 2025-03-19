const int numRows = 5;
const int numCols = 4;

int[,] array = new int[numRows, numCols];
Random rnd = new Random();
for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numCols; j++)
    {
        array[i, j] = rnd.Next(1, 101);
    }
}

Console.WriteLine("Исходный массив:");
PrintArray(array);

SortRowsBySum(array);


Console.WriteLine("\nОтсортированный массив по убыванию суммы строк:");
PrintArray(array);

static void SortRowsBySum(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numRows - 1; j++)
        {
            int sumCurrentRow = 0;
            int sumNextRow = 0;

            for (int k = 0; k < numCols; k++)
            {
                sumCurrentRow += array[j, k];
                sumNextRow += array[j + 1, k];
            }

            if (sumCurrentRow < sumNextRow)
            {
                for (int k = 0; k < numCols; k++)
                {
                    int temp = array[j, k];
                    array[j, k] = array[j + 1, k];
                    array[j + 1, k] = temp;
                }
            }
        }
    }
}
static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}