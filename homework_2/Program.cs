// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int size)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    return arr;
}

int OddNumbers(int[] array)
{
    int sumNumbers = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumNumbers += array[i];
    }
    return sumNumbers;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] numbers = RandomArray(10);
PrintArray(numbers);
int result = OddNumbers(numbers);
System.Console.WriteLine($"Сумма нечетных елементов массива по индексу равна: {result}");