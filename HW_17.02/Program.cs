Console.Clear();
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/


Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());
int num1 = num%10 * 10000 + (num/10)%10 * 1000 + (num/100)%10 * 100 + (num/1000)%10 * 10 + num/10000;

    if (num == num1)
    {
      Console.WriteLine("ДА!");
    }
    else
    {
      Console.WriteLine("Нет");
    }

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

double GetRangeCard(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double xpow = Math.Pow(Convert.ToDouble(x1 - x2), 2);
  double ypow = Math.Pow(Convert.ToDouble(y1 - y2), 2);
  double zpow = Math.Pow(Convert.ToDouble(z1 - z2), 2);
  double xyzsqrt = Math.Sqrt(xpow + ypow + zpow);

  return Math.Round(xyzsqrt, 2, MidpointRounding.ToZero); 

}
Console.WriteLine($"Расстояние между точками {GetRangeCard(3,6,8,2,1,-7)}");
Console.WriteLine($"Расстояние между точками {GetRangeCard(7,-5,0,1,-1,9)}");

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void PrintSqr(int num)
{
 int i = 1;
 while (i<num)
 {
    
    Console.Write($"{Math.Pow(i,3)}, ");
    i++;
 }    
    Console.Write($"{Math.Pow(i,3)}");
}


Console.Write("введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintSqr(num);
