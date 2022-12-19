int rec(int m, int n)
{
if (m == n)
return n;
return rec(m, n - 1) + n;
}
Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));
