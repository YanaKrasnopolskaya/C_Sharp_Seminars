// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// using System.Numerics;

// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rnd.Next(minValue, maxValue);

//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[] CreateArrai(int[,] matrix)
// {
//     int size = matrix.GetLength(0) * matrix.GetLength(1);
//     int[] arr = new int[size];
//     for (int k = 0; k < arr.Length; k++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 arr[k] = matrix[i, j];
//             }
//         }

//     }
//     return arr;
// }

// void PrintOut(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }

//     Console.Write($"{arr[^1]}");
// }

// int[,] array = CreateMatrix(4, 4, 0, 10);
// PrintMatrix(array);
// int[] newArray = CreateArrai(array);
// PrintOut(newArray);

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue) //Метод, который создает двумерный массив
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //Метод, который выводит двумерный массив в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          array[count] =matrix[i,j];
          count++;  
        }
        
    }
    return array;
}

void PrintArray(int[] arr)
{
    string str = "[" + Convert.ToString(arr[0]);
    for (int j = 1; j < arr.Length; j++)
    {
        str = str + ", " + Convert.ToString(arr[j]);
    }
    str = str + "]";
    Console.WriteLine(str);
}

void PrintDictionary(int[] array)
{
    int count=1;
    int currentNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]==currentNum)count++;
        else 
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = array[i];
            count=1;
        }
    }
     Console.WriteLine($"{currentNum} -> {count}");

}

int[,] customMatrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(customMatrix);
Console.WriteLine();
int[] arr = MatrixToArray(customMatrix);

Array.Sort(arr); 
PrintArray(arr);
PrintDictionary(arr);