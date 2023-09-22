// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SecondDigit(int number)
{
    int digit = number / 10 % 10;
    return digit;
}

bool IsNumberValid(int number)
{
    if (number >= 100 && number < 1000) 
    {
        return true;
    }    
    else if (number > -1000 && number <= -100) 
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число!");
        return false;
    }
}

bool numValid = false;
int num = 0;

while (!numValid)
{
    num = GetUserInput("Введите трёхзначное число: ");
    numValid = IsNumberValid(num);
}

int result = SecondDigit(num);
Console.WriteLine($"Вторая цифра числа {num} --> {result}");

