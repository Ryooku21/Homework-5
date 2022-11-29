// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int step = 0; step < array.Length; step++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[step] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] arr)
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

double FindArrayMax(double[] arr)
{
    double findMax = arr[0];
    for (int step = 0; step < arr.Length; step++)
    {
        if (findMax < arr[step])
        {
            findMax = arr[step];
        }
    }
    return findMax;
}

double FindArrayMin(double[] arr)
{
    double findMin = arr[0];
    for (int step = 0; step < arr.Length; step++)
    {
        if (findMin > arr[step])
        {
            findMin = arr[step];
        }
    }
    return findMin;
}

double[] array = CreateArray(5, 0, 100);
Console.WriteLine("Задан массив из вещественных чисел:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
double arrayMinMaxDiff = FindArrayMax(array) - FindArrayMin(array);
arrayMinMaxDiff = Math.Round(arrayMinMaxDiff, 1);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {arrayMinMaxDiff}");