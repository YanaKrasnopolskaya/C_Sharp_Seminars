// 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8



int numberToDigit = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка от 10 до 99: {numberToDigit}");

// int firstDigit = numberToDigit / 10;
// int secondDigit = numberToDigit % 10;

// if (firstDigit > secondDigit) 
// {
//     Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; тернарный оператор(возвращается правда или ложь)
                                        // ? - тогда    : - иначе
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(numberToDigit);
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");