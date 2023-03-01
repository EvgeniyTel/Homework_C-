Console.Clear();

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int[] array = FillArray(7, 101, 501);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine($"Количество четных чисел = {GetEvenValueInArray(array)}");

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}
int[] GetEvenValueInArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int rezult = 0;
        if (array[i] % 2 == 0)
            rezult++;
    }
    return rezult;
}*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

int[] array = FillArray(4, 1, 200);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}]");
Console.WriteLine(
    $"Сумма элементов на нечетных нечетных позициях = {GetSumUnfairPositionArray(array)}"
);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}

int[] GetSumUnfairPositionArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] % 2 == 1)
            sum += array[i];
    }
    return sum;
}*/


