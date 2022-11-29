// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random(). Next(10, 100);
Console.WriteLine($"Сгенерировано случайное число {num}" );
int x1 = num/10;
int x2 = num %10; // остаток деления
if (x1 > x2) Console.WriteLine($"Наибольшая цифра этого числа это {x1}");
else if (x1 < x2) Console.WriteLine($"Наибольшая цифра этого числа это {x2}");
else Console.WriteLine("Цифры одинаковые");
for (int i = 0; i < num; i=i+2) Console.Write($" {i} ");
