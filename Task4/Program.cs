const int numPeople = 18;
const int numMonth = 12;

decimal[,] salaries = new decimal[numPeople, numMonth];
Random rnd = new Random();

for (int i = 0; i < numPeople; i++)
{
    for (int j = 0; j < numMonth; j++)
    {
        salaries[i, j] = Math.Round((decimal)(rnd.Next(1000, 5001)), 2);
    }
}
Console.WriteLine("Введите число для проверки: ");
decimal threshold = Convert.ToDecimal(Console.ReadLine());

decimal annualIncomeFirstPerson = 0;
for (int j = 0; j <numMonth; j++)
{
    annualIncomeFirstPerson += salaries[0, j];
}

bool isGreater =  annualIncomeFirstPerson > threshold;

Console.WriteLine($"\nГодовой доход первого человека: {annualIncomeFirstPerson:C}");
if (isGreater)
{
    Console.WriteLine($"Годовой доход первого человека больше {threshold:C}.");
}
else
{
    Console.WriteLine($"Годовой доход первого человека не больше {threshold:C}.");
}