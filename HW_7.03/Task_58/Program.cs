/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
Console.Clear();

int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int rowsLenght = matrix1.GetLength(1);
    int[,] resultMatrix = new int[rows, rowsLenght];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rowsLenght; j++)
        {
            int sum = 0;
            for (int k = 0; k < rows; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
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
int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };
PrintArr(matrix1);
Console.WriteLine($"  x ");
PrintArr(matrix2);
Console.WriteLine($"  = ");
PrintArr(MatrixMult(matrix1, matrix2));
