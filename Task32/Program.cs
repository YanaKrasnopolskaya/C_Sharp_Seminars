// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrarRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void SignInversion(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // arr[i] *= -1;
        arr[i] = -arr[i];
    }
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");
}
int[] randArray = CreateArrarRndint(5, -10, 11);
Console.Write("[");
PrintOut(randArray);
Console.Write("] --> ");
SignInversion(randArray);
Console.Write("[");
PrintOut(randArray);
Console.Write("]");