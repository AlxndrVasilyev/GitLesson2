// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// пишу для общего случая

int SecondDigit(int Number)
{
    return Number / 10 % 10;
}
Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100 || n > 999)
{
    System.Console.WriteLine(n + " не является трёхзначным числом");
}   
else
{
    Console.WriteLine("Вторая цифра трёхзначного числа - " + SecondDigit(n));
}