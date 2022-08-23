// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// с помощью рекурсии

string f(int n)
{
    if (n == 1)
        return "1 ";

    return f(n-1) + ", " + Convert.ToString(n);
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));

