// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void FillArray(int[,] matrix, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(start, end);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void EvenCount(int[,] matr2)
{
    int count = 0;
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            if (matr2[i,j] % 2 == 0) count = count +1;
        }
        
    }
Console.WriteLine($"Количество четных элементов = {count}");
}

Console.WriteLine("Введите количество строк n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов k");
int k = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[n, k];
FillArray(matrix, 100, 1000);
PrintArray(matrix);
Console.WriteLine();

EvenCount(matrix);