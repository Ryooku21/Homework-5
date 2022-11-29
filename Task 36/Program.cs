// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int FindSummNegativeElements(int[] arr)
{
    int negativeSumm = 0;
    for (int step = 1; step < arr.Length; step += 2)
    {
        negativeSumm += arr[step];
    }
    return negativeSumm;
}

int[] array = CreateArray(4, 0, 10);
Console.WriteLine("Задан массив из случайных чисел:");
PrintArray(array);
int result = FindSummNegativeElements(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {result}");