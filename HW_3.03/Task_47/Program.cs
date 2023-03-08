Console.Clear();
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

double[,] GetArrNaturalNum(int rows, int rowsLenght, int genEvenNumb, int probabilityNegativ = 3)
{
    double[,] arr = new double[rows, rowsLenght];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rowsLenght; j++)
        {
            arr[i, j] = Math.Round(rnd.NextDouble() * genEvenNumb, 2, MidpointRounding.ToZero);
            if (rnd.Next(0, probabilityNegativ) == 0)
            {
                arr[i, j] *= -1;
            }
        }
    }
    return arr;
}
void PrintArr(double[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} |");
        }
        Console.WriteLine($"");
    }
}
PrintArr(GetArrNaturalNum(3, 4, 10));
