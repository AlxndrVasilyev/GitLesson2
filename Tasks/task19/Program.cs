// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// математический вариант 

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    Console.WriteLine($"Число {num} - палиндром");
else
    Console.WriteLine($"Число {num} - не палиндром");

// или через сравнение значений по индексам

// Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine();
// int length = number.Length;
// if (length != 5)
//     Console.WriteLine("Вы ввели не пятизначное число");
// else if (number[0] == number[4] && number[1] == number[3])
//     Console.WriteLine($"Число {number} - палиндром");
// else
//     Console.WriteLine($"Число {number} - не палиндром");