// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetUserInput(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Thirdnumber(int num)
{
    int res = 0;
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
        if (num > 99 || num < 1000)
        {
            res = num % 10;
        }
    return res;
}

bool ValidNumber(int num)
{
    if (num > -100 && num < 100)
    {
        Console.WriteLine("Третья цифра отсутствует!");
        return false;
    }
    return true;
}

int number = GetUserInput("Введите любое целое число: ");   
if (ValidNumber(number))
{
    Console.WriteLine(Thirdnumber(number));
}
