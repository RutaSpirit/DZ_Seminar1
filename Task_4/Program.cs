//Напишите программу, которая на вход принимает три числа, и выдает максимальное из этих трех
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 3-е число: ");
int l = Convert.ToInt32(Console.ReadLine());
int max = n;
{ if (m > n > l)
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
if (m == n == l)
{
    Console.Write("Вы ввели одинаковые числа!");
}