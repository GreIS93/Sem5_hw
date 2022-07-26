// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
}

void OddPosSum(int[] arr2)
{
    int sum = arr2[0];
    for (int i = 1; i < arr2.Length; i++)
    {
        if (i % 2 == 0) sum = sum +arr2[i];    
    }
Console.WriteLine(sum);
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

OddPosSum(array);