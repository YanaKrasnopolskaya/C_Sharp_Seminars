// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool NatularsCheck(int num)
{
    if (num < 0) return false;

    else return true;
}

void NaturalsNumber(int num)
{
    if (num == 0) return;

    Console.Write($"{num}  ");
    NaturalsNumber(num - 1);
}

int number = GetUserInput("Введите натуральное число: ");
if(NatularsCheck(number))
{
    Console.Write($"{number} --> ");
    NaturalsNumber(number);
}
else
{
    Console.WriteLine("Вы ввели не натуральное число!");
}