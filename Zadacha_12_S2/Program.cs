Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 =num1%10;
if (num2*num2 == num1)
{
    Console.Write ($"{num2}, {num1} -> Кратно");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> Не кратно, остаток {num3} ");
}