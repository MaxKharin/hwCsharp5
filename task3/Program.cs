// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double [] InitArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]:f2}| ");
    }
    Console.WriteLine();
}

double DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    return max - min;
}

double[] myArray = InitArray(10, 10, 100);
PrintArray(myArray);
double dif = DifferenceMinMax(myArray);
Console.WriteLine($"The difference between max and min is {dif:f2}");