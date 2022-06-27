// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел

int[] InitArray(int ar, int min, int max)
{
    int[] array = new int[ar];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}| ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int[] myArray = InitArray(10, 100, 1000);
PrintArray(myArray);
int count = CountEvenNumbers(myArray);
Console.WriteLine($"Even numbers count: {count}");