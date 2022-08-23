// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int f(int n)
{
    if (n < 10)
        return n;

    return f(n / 10) + n % 10;
}


int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f (n));