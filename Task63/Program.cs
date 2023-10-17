// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.

int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void NaturalsNumber(int num)
{
    if (num == 0) return;

    NaturalsNumber(num - 1);
    Console.Write($"{num}  ");

}



int number = GetUserInput("Введите натуральное число: ");
Console.Write($"{number} --> ");
NaturalsNumber(number);

