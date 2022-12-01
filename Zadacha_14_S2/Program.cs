// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int div1 = num%7;
int div2 = num%23;
if (div1==0 && div2==0)
Console.WriteLine($"Число {num} кратно 23 и 7");
else
Console.WriteLine($"Число {num} не кратно 23 и 7");

