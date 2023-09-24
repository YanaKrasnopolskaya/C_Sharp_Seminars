// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetUserInput(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool CorrectInput(int digit)
{
    if (digit > 0 && digit < 8) return true;
    else 
    {
    Console.WriteLine("Некоректный ввод!");
    return false;
    }
}

bool DaysWeek(int digit)
{
    if (digit > 5)
    {
        Console.WriteLine("День является выходным!");
        return true;
    }
    else
    {
        Console.WriteLine("День не является выходным");
        return false;
    }
}

int number = GetUserInput("Введите номер дня недели: ");
if (CorrectInput(number))
{
    DaysWeek(number);
}