// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array = GetArray(GetRows(), GetColumns(), GetMinValue(), GetMaxValue());
Console.WriteLine();
PrintArray(array);

int GetRows()
{
    Console.Write("Enter massive rows number (m): ");
    int rows = int.Parse(Console.ReadLine());
    return rows;
}

int GetColumns()
{
    Console.Write("Enter massive columns number (n): ");
    int columns = int.Parse(Console.ReadLine());
    return columns;
}

double GetMinValue()
{
    Console.Write("Enter massive minimum number: ");
    double minimum = double.Parse(Console.ReadLine());
    return minimum;
}

double GetMaxValue()
{
    Console.Write("Enter massive maximum number: ");
    double maximum = double.Parse(Console.ReadLine());
    return maximum;
}

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(inArray[i, j], 2)}  ");
        }
        Console.WriteLine();
    }
}