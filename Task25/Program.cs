// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetUserInput(string message)
{
    Console.Write(message);
    double num = Convert.ToInt64(Console.ReadLine());
    return num;
}

double Exponentiation(double num, double deg)
{
    double res = Math.Pow(num, deg);
    return res;
}

bool NaturalNumber(double num)
{
    if (num > 0) return true;
    else
    {
        Console.WriteLine("Второе число не может быть отрицательным!");
        return false;
    }
}

double number = GetUserInput("Введите первое число: ");
double degree = GetUserInput("Введите второе число: ");

if (NaturalNumber(degree)) 
{
    double result = Exponentiation(number, degree);
    Console.WriteLine($"{number} в степени {degree} = {result}");
}    