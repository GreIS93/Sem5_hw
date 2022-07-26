// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
void FillArray(double[] arr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
  
        {
            arr[i] = rnd.Next(start, end) + Math.Round((rnd.NextDouble()), 1);
        }
    
}
void PrintArray(double[] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    
        {
            Console.Write($"({arr1[i]}) ");
        }
        Console.WriteLine();
    
}
double Max(double[] arr2)
{
    double max = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        
        
            if (arr2[i] > max)
            {
                max = arr2[i];
            
        }
    }
    return max;
}
double Min(double[] arr3)
{
    double min = 0;
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        
            if (arr3[i] < min)
            {
                min = arr3[i];
            }
        
    }
    return min;
}

double[] array = new double[10];
FillArray(array, -9, 10);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine($"max - min = {Max(array)-Min(array)}");