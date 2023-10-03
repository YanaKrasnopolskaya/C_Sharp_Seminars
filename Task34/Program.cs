// Задача 34: 
//1. Задайте массив заполненный случайными положительными 
//   трёхзначными числами. 
//2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
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

int CountEvenNumbInArray(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count ++;
    }  

    return count; 
}

int[] array = CreateArrayRndInt(10, 100, 999);
Console.Write("[");
PrintOut(array);
Console.Write("]");
Console.WriteLine();
int countEvenNumbInArray = CountEvenNumbInArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {countEvenNumbInArray}");