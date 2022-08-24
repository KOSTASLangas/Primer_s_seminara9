// Дано натуральное число N и последовательность из N элементов. 
// Требуется вывести эту последовательность в обратном порядке без массивов и циклов.

string f(int n)
{
    if (n == 0)
        return "";

    int k = Convert.ToInt32(Console.ReadLine());
    return f(n-1)  + " " + Convert.ToString(k);
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));