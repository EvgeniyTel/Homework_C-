/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/
Console.Clear();

int GetMinSumRowElem(int[,] arr)
{
    int rezult = 0;
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);

    int[] sumArr = new int[rows];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumArr[i] += arr[i, j];
        }
    }
    rezult = Array.IndexOf(sumArr, sumArr.Min());
    int translateIndexToNum = 1;
    return rezult + translateIndexToNum;
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
int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, {5, 2, 6, 7}};

PrintArr(arr);
Console.WriteLine($"");
Console.WriteLine($"Номер строки с минимальной суммой элементов {GetMinSumRowElem(arr)}.");