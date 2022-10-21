// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = GetArray(GetRows(), GetColumns(), GetMinValue(), GetMaxValue());
PrintArray(array);
Console.WriteLine();
ShowElement(array);

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
    Console.Write("Enter massive maximum number: ");
    int maximum = int.Parse(Console.ReadLine());
    return maximum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ShowElement(int[,] arr)
{
    Console.Write("Enter element position (row): ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Enter element position (column): ");
    int n = int.Parse(Console.ReadLine());
    if (m < 0 || m > arr.GetLength(0) || n < 0 || n > arr.GetLength(1))
    {
        Console.WriteLine("ERROR! Incorrect position, no elements");
    }
    else Console.WriteLine($"Element on position [{m},{n}] = {arr[m, n]}");
}