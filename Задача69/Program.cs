// Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В 
// с помощью рекурсии

int f(int n, int m)
{
    if (m == 0)
        return 1;

    return f(n, m-1) * n;
}


int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n, m));