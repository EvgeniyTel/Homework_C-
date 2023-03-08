Console.Clear();

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

double[] GetArithmeticNumArray(int[,] arr)
{
    double result = 0;
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    double[] resultArr = new double[rowsLenght];
    for(int i = 0; i < rowsLenght; i++)
    {
        result = 0;
        for(int j = 0; j < rows; j++)
        {
            result += Convert.ToDouble(arr[j, i]);
        }
        result /= Convert.ToDouble(rows);
        resultArr[i] = Math.Round(result, 1, MidpointRounding.ToZero);
    }
    return resultArr;
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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
int[,] arr = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
PrintArr(arr);
Console.WriteLine($"");
Console.WriteLine($"Средние арифметическое = [{string.Join(", ",GetArithmeticNumArray(arr))}].");