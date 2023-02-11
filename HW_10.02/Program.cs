//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите A: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
  Console.WriteLine("max=" + number1);
}
else if (number2 > number1)
{
  Console.WriteLine("max=" + number2);
}


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите три числа ");
int numb1 = int.Parse(Console.ReadLine());
int numb2 = int.Parse(Console.ReadLine());
int numb3 = int.Parse(Console.ReadLine());
int max = numb1;

if (numb1 > numb3)
{
  Console.WriteLine("max=" + numb1);
}
else if (numb2 > numb3)
{
  Console.WriteLine("max=" + numb2);
}
else
{
  Console.WriteLine("max=" + numb3);
}




//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}



//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int nu = int.Parse(Console.ReadLine());
int u = 0;
while (u <= nu)
{
  Console.WriteLine($"{u} ");
  u=u+2;
}



