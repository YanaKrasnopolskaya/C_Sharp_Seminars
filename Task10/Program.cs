// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SecondDigit(int number)
{
    int digit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number}: {digit}");
    return digit;

}

bool CorrectInput(int number)
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

// bool numValid = false;
// int num = 0;

// while (!numValid)
// {                                                        Этот пример позволяет выводить GetUserInput до тех пор,
//     num = GetUserInput("Введите трёхзначное число: ");   пока не будет введено корректное число.
//     numValid = IsNumberValid(num);
// }

int result = GetUserInput("Введите трёхзначное число: ");

if (CorrectInput(result))
{
    SecondDigit(result);
}



    

