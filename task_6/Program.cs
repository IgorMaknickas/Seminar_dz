// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("Не четное");
}
