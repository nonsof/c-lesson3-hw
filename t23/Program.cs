// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Write a num pls");
int num1 = Convert.ToInt32(Console.ReadLine());
int lol = 1; 
if (num1 <= 0)
{
    Console.WriteLine("idk what are you doing, try again lol");
}
else 
{
    while (lol<=num1)
    {int res = lol * lol*lol;
        Console.WriteLine(res);
        lol++;}
}