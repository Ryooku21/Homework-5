// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int step = 0; step < array.Length; step++)
    {
        array[step] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int step = 0; step < arr.Length; step++)
    {
        if (step == arr.Length - 1)
        {
            Console.Write($"{arr[step]}");
        }
        else
        {
            Console.Write($"{arr[step]}, ");
        }
    }
    Console.Write("]");
}

int FindPositive(int[] arr)
{
    int positiveSumm = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            positiveSumm++;
        }
    }
    return positiveSumm;
}

int[] array = CreateArray(4, 100, 999);
Console.WriteLine("Задан массив из случайных положительных трёхзначных чисел:");
PrintArray(array);
int result = FindPositive(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в данном массиве равно: {result}");