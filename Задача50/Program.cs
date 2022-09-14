Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void PrintArray(int[,] matr)
{
   Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { Console.Write($"{matr[i, j]} "); }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        matr[i,j] = new Random().Next(1,1000);
    }
}
void SearchArray(int[,] matr)
{
    Console.WriteLine("Введите координаты");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > m && b > n)
        Console.WriteLine("такого числа нет");
    else
    {
        object c = matr.GetValue(a, b);
        Console.WriteLine();
        Console.WriteLine($"Элемент = {c}");
    }
}

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
SearchArray(matrix);