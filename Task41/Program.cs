// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NumbersPowersOfZero(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) num ++; 
    }
    return num;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

int sizeUzer = GetUserInput("Введите количество вводимых чисел: ");
int[] arrayNumber = new int[sizeUzer];

for (int i = 0; i < sizeUzer; i++)
{
    arrayNumber[i] = GetUserInput("Введите целое число: ");
}

PrintOut(arrayNumber);
Console.WriteLine();
int numbersPowersOfZero = NumbersPowersOfZero(arrayNumber);
Console.WriteLine($"Количество чисел > 0 от пользователя: {numbersPowersOfZero}");
