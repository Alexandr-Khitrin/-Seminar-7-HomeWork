// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[5, 5];

Console.Write("Введите строку: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

FillArray(array);
ArrayPosition(array);
Console.WriteLine();
PrintArray(array);

void PrintArray(int[,] matr)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1, 10]
        }
    }
}
void ArrayPosition(int[,] position)
{
    if (row < 0 || row > array.GetLength(0) - 1 || column < 0 || column > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента нет в массиве!");
    }
    else
    {
        Console.WriteLine($"Значение элемента массива: {array[row, column]}");
        Console.WriteLine();
    }
}
