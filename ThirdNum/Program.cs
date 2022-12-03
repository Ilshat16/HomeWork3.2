// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int n3 = 0;
int newNum = num;
if (num < 100) Console.WriteLine($"У числа {num} нет третьей цифры");
else
{
    while (newNum >= 1000)
    {
        newNum = newNum / 10;
    }
    n3 = newNum % 10;
    Console.WriteLine($"У чмсла {num} третьей цифрой является {n3}");
}
