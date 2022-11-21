//Напишите программу, которая на вход принимает число и выдает его квадрат(число, умноженное на само себя)
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
if (m * m == n)
    Console.Write("yes");
else
    Console.Write("no");