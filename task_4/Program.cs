﻿// See Напишите программу, вводит 3 числа и вадет максимальное из чисел
Console.WriteLine("Введите первое число ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int numC = int.Parse(Console.ReadLine());
int max = numA;
if (numB > max)max = numB;
if (numC > max)max = numC;
Console.WriteLine("max = " + max);
