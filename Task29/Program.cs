// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int arrLength)
{
    int[] arr = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    //var str = string.Join(", ", arr);
    Console.Write($"{string.Join(", ", arr)} --> [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}]");
        }
    }
}
int[] array = RandomArray(8);
PrintArray(array);