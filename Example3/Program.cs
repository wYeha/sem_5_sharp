// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double[] MaxMinDifference(double[] array)
{
    double max = array[0], min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return new double[] { max, min };
}

double[] arr = CreateArrayRndDouble(6);
PrintArray(arr);
double answer = Math.Round(MaxMinDifference(arr)[0] - MaxMinDifference(arr)[1], 2);
Console.WriteLine($" => {MaxMinDifference(arr)[0]} - {MaxMinDifference(arr)[1]} = {answer}");