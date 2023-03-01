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

