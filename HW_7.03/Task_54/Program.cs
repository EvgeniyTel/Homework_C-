/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/
Console.Clear();

void GetDescendingStructRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int h = 0; h < arr.GetLength(1) - 1; h++)
            {
                if (arr[i, h] < arr[i, h + 1])
                {
                    int point = arr[i, h + 1];
                    arr[i, h + 1] = arr[i, h];
                    arr[i, h] = point;
                }
            }
        }
    }
}
void PrintArr(int[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]}| ");
        }
        Console.WriteLine($"");
    }
}
int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArr(arr);
Console.WriteLine($"");
GetDescendingStructRows(arr);
PrintArr(arr);
