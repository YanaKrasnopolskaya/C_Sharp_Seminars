// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    
    Console.Write($"{arr[^1]}");
}

int SumElementsAnOddPositions(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }

    return sum;
}

int[] array = CreateArrayRndint(8, 1, 100);
PrintOut(array);
Console.WriteLine();
int sumElementsAnOddPositions = SumElementsAnOddPositions(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sumElementsAnOddPositions}");
