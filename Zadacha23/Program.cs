//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
int m=1;
while (Math.Abs(N) -m >= 0)
{
    Console.Write($"{m*m*m},");
    m++;
}
Console.Write("\b \b");