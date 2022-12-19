int rec(int n, int m)
{
if (n == 0)
    return m + 1;
else if (n != 0 && m == 0)
    return rec(n - 1, 1);
else
    return rec(n - 1, rec(n, m - 1));
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));