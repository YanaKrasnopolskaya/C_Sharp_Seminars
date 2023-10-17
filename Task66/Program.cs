// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;

public class Answer
{
    /// <summary>
    /// Метод для пользовательского ввода
    /// </summary>
    /// <param name="message">сообщение пользователю</param>
    /// <returns>целое число</returns>
    public static int GetUserInput(string message)
    {
        Console.Write(message);
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    /// <summary>
    /// Метод проверки числа на натуральность
    /// </summary>
    /// <param name="num">число</param>
    /// <returns>true || false</returns>
    public static bool NatularsCheck(int num)
    {
        if (num < 1) return false;

        else return true;
    }

    /// <summary>
    /// Метод подсчёта суммы натуральных чисел от M до N
    /// </summary>
    /// <param name="num1">первое натуральное число</param>
    /// <param name="num2">второе натуральное</param>
    /// <returns>сумма</returns>
    public static int SumNaturalsElements(int num1, int num2)
    {
        int sum = 0;

        if (num2 >= num1)
        {
            sum = num1 + SumNaturalsElements(num1 + 1, num2);
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        int number1 = GetUserInput("Введите первое число: ");
        int number2 = GetUserInput("Введите второе натуральное число: ");
        int sumNaturalsNumbers = 0;

        if (NatularsCheck(number1) && NatularsCheck(number2))
        {
            if (number1 > number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
                sumNaturalsNumbers = SumNaturalsElements(number1, number2);
                Console.WriteLine($"Сумма натуральных чисел от {number1} до {number2} равна: {sumNaturalsNumbers}");

            }
            else
            {
                sumNaturalsNumbers = SumNaturalsElements(number1, number2);
                Console.WriteLine($"Сумма натуральных чисел от {number1} до {number2} равна: {sumNaturalsNumbers}");
            }

        }
        else
        {
            Console.WriteLine("Одно из чисел не является натуральным! Вводите только натуральные числа!");
        }
    }

}