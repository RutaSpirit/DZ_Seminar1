//Напишите программу, которая на вход принимает число и выдает, является ли число четным
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Convert.ToInt32(n > 5));

if (n % 2 == 0)
    Console.Write("yes");
else
    Console.Write("no");
