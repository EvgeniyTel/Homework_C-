Console.Clear();
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] array = FillArray(4, 100, 500);

Console.WriteLine($"В массиве: [{string.Join(" ",array)}]");
Console.WriteLine(
    $"Количество четных чисел = [{string.Join(" ", GetEvenValueInArray(array))}]"
);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i  < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return rezult;
     
}
int[] GetEvenValueInArray(int[] array)
{
     int rezult = 0;
 for (int i = 0; i < array.Length; i++)
    {
 if (array  % 2 == 1)
 rezult++;
    }
 return rezult;
}

