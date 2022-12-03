// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру дня недели: ");
int dayNum = int.Parse(Console.ReadLine());
if (dayNum > 0 & dayNum < 8)
{
    if (dayNum >= 6 & dayNum <= 7) Console.WriteLine($"{dayNum} день недели выходной");
    else Console.WriteLine($"{dayNum} день недели не является выходным");
}
else Console.WriteLine("Такого дня недели нет");