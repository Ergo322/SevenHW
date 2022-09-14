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
            matr[i, j] = new Random().Next(1, 10);
    }
}
void MiddleNumArray(int[,] matr)
{
    double sum = 0;
    for (int j = 0; j < m; j++)
    {
        for (int i = 0; i < n; i++)
        {
            sum = sum + matr[i, j];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {sum}/{n} = {(double)sum / n}");
        sum = 0;
    }
}

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
MiddleNumArray(matrix);