// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] RandomDoubleArray(int size)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
    }
    return arr;
}

double DiffMaxMinElements(double [] array)
{
    double diff = 0;
    Array.Sort(array);
    if(array.Length>0)
    {
        diff = array[array.Length -1] - array[0];
    }
    return diff;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] numbers = RandomDoubleArray(10);
PrintArray(numbers);
double result = DiffMaxMinElements(numbers);
Console.WriteLine($"Разница между максимальным и минимальным елементом массива равна: {result}");