// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number <= 99999)
{
    string str= number.ToString();
    if (str[0]==str[4]&& str[1]==str[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else 
{
    Console.WriteLine("Не пятизначное число");
}
