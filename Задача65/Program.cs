// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// с помощью рекурсии



string f(int m, int n)
{
    if (n == m)
        return Convert.ToString(m);

    return f(m, n-1) + ", " + Convert.ToString(n);
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
