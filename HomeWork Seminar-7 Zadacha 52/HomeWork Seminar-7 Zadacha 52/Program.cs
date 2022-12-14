Console.Write("Введите количество строк: ");
int rowsVol = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columnsVol = int.Parse(Console.ReadLine()!);

int[,] array = new int[rowsVol, columnsVol];

FillArray(array);
PrintArray(array);
ArrayMean(array);

void ArrayMean(int[,] mean)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(1); i ++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j ++)
        {
            sum += array[j, i];
        }
        Console.Write($"{sum / array.GetLength(0)}\t|");
    }

}


void PrintArray(int[,] matr)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t|");
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

