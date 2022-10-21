// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArray(GetRows(), GetColumns(), GetMinValue(), GetMaxValue());
PrintArray(array);
Console.WriteLine();
AverageInColumn(array);

int GetRows()
{
    Console.Write("Enter massive rows number: ");
    int rows = int.Parse(Console.ReadLine());
    return rows;
}

int GetColumns()
{
    Console.Write("Enter massive columns number: ");
    int columns = int.Parse(Console.ReadLine());
    return columns;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetMinValue()
{
    Console.Write("Enter massive minimum number: ");
    int minimum = int.Parse(Console.ReadLine());
    return minimum;
}

int GetMaxValue()
{
    Console.Write("Enter massive minimum number: ");
    int maximum = int.Parse(Console.ReadLine());
    return maximum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void AverageInColumn(int[,] arr)
{
    double average = 0;
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int i = 0;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        average = sum / (i + 1);
        Console.WriteLine($"Sum of elements in column {j} = {sum}. Average = {Math.Round(average, 2)}");
    }
}