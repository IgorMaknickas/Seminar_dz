// Напишите программу, которая вводит (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
for ( int i = 2; i <= a; i++)
if (i % 2 == 0)
Console.WriteLine(" Четные числа = " + i);
