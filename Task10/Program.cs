// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondDigit(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return firstDigit * 10 + thirdDigit;
}

int numberToDigit = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка от 100 до 999: {numberToDigit}");

// int firstDigit = numberToDigit / 100;
// int thirdDigit = numberToDigit % 10;
// int result = firstDigit * 10 + thirdDigit;

int result = DeleteSecondDigit(numberToDigit);
Console.WriteLine($"Итоговое число при удалении второго числа:  {result}");
