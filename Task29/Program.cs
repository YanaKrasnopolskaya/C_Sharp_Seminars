// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

//void PrintArray(int[] arr)
//{
    
    // Console.Write($"{string.Join(", ", arr)} --> [");      srtring.Join - метод для склеивания элементов массива с
    // for (int i = 0; i < arr.Length; i++)                    заданным разделителем.
    // {
    //     if (i < arr.Length - 1)
    //     {                                                       //var str = string.Join(", ", arr);
    //         Console.Write($"{arr[i]}, ");                         var - тип, который даёт компилятору самому выбрать тип данных
    //     }                                                         для str.
    //     else
    //     {                       
    //         Console.Write($"{arr[i]}]");
    //     }
    // }
//}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i <  arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else Console.Write($"{arr[i]}");
    }
    
}

int[] array = RandomArray(8, 1, 10);
PrintArray(array);
Console.Write($" --> [");
PrintArray(array);
Console.Write("]");