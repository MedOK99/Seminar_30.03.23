﻿/* Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу чисел 
от 1 до N в третьей степени.

double number = 3;
Console.WriteLine(Math.Pow(number, 3));  
_____________________________________
for (int i = 0; i < 10; i += 2)
{
    Console.Write(i + ", ");
}

Console.WriteLine();

int counter = 0;
while(counter < 10)
{
    Console.Write(counter + ", ");
    counter = counter + 2;
}
--------------------------------------- */

Console.Clear();

Console.WriteLine("Введите число:");

double cube = double.Parse(Console.ReadLine());

for (double i = 1; i < cube; i++)
{
  Console.Write($"{(Math.Pow(i, 3))},");
}
Console.Write(Math.Pow(cube, 3));

