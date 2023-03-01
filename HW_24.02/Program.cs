Console.Clear();
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] array = FillArray(7, 100, 500);

Console.WriteLine($"В массиве: [{string.Join(" ",array)}]");
Console.WriteLine($"Количество четных чисел = {GetEvenValueInArray(array)}");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i  < array.Length; i++)
    {
     array[i] = rnd.Next(min, max + 1);
    }
    return array ;
     
}
int[] GetEvenValueInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            count++;
    }
    return count ;
}

