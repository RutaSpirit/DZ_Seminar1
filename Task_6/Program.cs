﻿Console.Clear();
int n = new Random().Next(10, 100);
Console.Write($"Случайное число: {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.Write(n1);
else 
    Console.Write(n2);