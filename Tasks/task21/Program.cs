// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine ("Введите поочерёдно координаты 1-ой точки (x, y, z):");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

System.Console.WriteLine ("Введите поочерёдно координаты 2-ой точки: (x, y, z):");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

// записываем формулу для вычисления расстояния между двумя точками в пространстве AB = √((xb - xa)ˆ2 + (yb - ya)ˆ2 + (zb - za)ˆ2)
// разбиваю формулу на две части

double SumOfPows = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
double distance3D = Math.Sqrt(SumOfPows);
System.Console.WriteLine($"Расстояние между двумя точками с указанными координатами составляет {distance3D}");
