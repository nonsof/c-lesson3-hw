// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("take a 5-digital number");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] n5m = new int [n];

// Console.WriteLine("take a 5-digital number");
// int num = Convert.ToInt32 (Console.ReadLine());
// int[] mA = new int [5];
// Console.WriteLine(mA);


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}