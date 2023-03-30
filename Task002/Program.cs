/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 

sqrt((x1-x2)^2 + (y1-y2)^2)   */

Console.WriteLine("Введите координаты X1:");

int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y1:");

int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты X2:");

int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y2:");

int y2 = int.Parse(Console.ReadLine());

double answer = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)); 

Console.WriteLine(Math.Round(answer, 2));
