// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] InitArray(int ar, int min, int max)
{
    int[] array = new int[ar];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

int OddIndexNumSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int[] myArray = InitArray(10, 0, 10);
PrintArray(myArray);
int sum = OddIndexNumSum(myArray);
Console.WriteLine($"The sum of odd index numbers is {sum}");
