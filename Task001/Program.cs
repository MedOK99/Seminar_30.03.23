// 1 : x > 0 И y > 0
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой 
// четверти (x и y).

Console.WriteLine("Введите четверть");
int x = int.Parse(Console.ReadLine());

if (x == 1)
{
  Console.WriteLine("x > 0 и y > 0");
}
else if (x == 2)
{
  Console.WriteLine("x < 0 и y > 0");
}
else if (x == 3)
{
  Console.WriteLine("x < 0 и y < 0");
}
else if (x == 4)
{
  Console.WriteLine("x > 0 и y < 0");
}
else
{
  Console.WriteLine("Не верное значение четверти!");
}