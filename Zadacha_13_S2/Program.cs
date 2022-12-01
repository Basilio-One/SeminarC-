int num = new Random(). Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное трехзначное число {num}" );
int x1 = num/100;
int x2 =  num%10; // остаток деления
//Console.WriteLine($"{num} -> {x1}{x2}");
Console.Write(x1);
Console.Write(x2);