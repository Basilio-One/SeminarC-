// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random(). Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число {num}" );
int x1 = num%1;
int x2 = x1*10;
// int x8 = num/10-%2;
int x3 = x1%2;

Console.WriteLine($"Наибольшая цифра этого числа X1  {num}");
Console.WriteLine($"Наибольшая цифра этого числа X2  {x2}");
Console.WriteLine($"Наибольшая цифра этого числа X3 {x3}"); q

