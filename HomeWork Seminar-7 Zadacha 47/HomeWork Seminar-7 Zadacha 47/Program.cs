Random random = new Random();
Console.Write("Введите количество строк: ");
int linesVol = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = int.Parse(Console.ReadLine());
double[,] array = new double[linesVol, columnsVol];

FillArray(array);

void FillArray(double[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = random.NextDouble() * 100;
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}