Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int n2 = num / 10 % 10;
Console.WriteLine($"Вторая цифра числа {num} является {n2}");