//Напишите программу, которая на вход принимает два числа, и выдает, какое число большее, а какое меньшее
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
int max = n;
{ if (m > n)
  {
    max = m;
    Console.Write("max = ");
    Console.WriteLine(max);
  }
  else
  {
    max = n;
    Console.Write("max = ");
    Console.WriteLine(max);
   }
}
if (m == n)
{
    Console.Write("Вы ввели одинаковые числа!");
}