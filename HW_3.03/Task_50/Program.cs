Console.Clear();

/*Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,1 -> 9
1,7 -> элемента с данными индексами в массиве нет*/

void GetSearchNumIndex(int[,] arr, int stroka, int stolb)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    if(stroka < 0 || stroka >= rows || stolb < 0 || stolb >= rowsLenght)
    {
        Console.WriteLine($"Введены индексы {stroka} и {stolb} - Число не найдено");
    }
    else
    {
        Console.WriteLine($"Введены индексы {stroka} и {stolb} число по индексу = {arr[stroka, stolb]}");
    }
}
void StartProg(int[,] arrIndex, int[,] arr)
{
    int rows = arrIndex.GetLength(0);
    int rowsLenght = arrIndex.GetLength(1);
    PrintArr(arr);
    Console.WriteLine($" ");
    int spamFirstIndex = 0;
    int spamSecondIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        spamFirstIndex = arrIndex[i, 0];
        spamSecondIndex = arrIndex[i, 1];
        GetSearchNumIndex(arr, spamFirstIndex, spamSecondIndex);
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

int[,] arrSearch = new int[,] {{0, 2}, {1, 1}, {1, 7}};
int[,] arr = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
StartProg(arrSearch, arr);
