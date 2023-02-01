// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] RandomArray(int size)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
    return arr;
}

int EvenNumbers(int[] numbers)
{
    int evenN = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0) evenN += 1;
        else continue;
    }
    return evenN;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = RandomArray(12);
PrintArray(array);
int result = EvenNumbers(array);
System.Console.WriteLine($"Сумма четных чисел равна: {result}");