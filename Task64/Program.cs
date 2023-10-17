// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
public class Answer
{
    /// <summary>
    /// Метод пользовательского ввода
    /// </summary>
    /// <param name="message">сообщение для пользователя</param>
    /// <returns>целое число</returns>
    public static int GetUserInput(string message)
    {
        Console.Write(message);
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    /// <summary>
    /// Метод проверки на натуральность
    /// </summary>
    /// <param name="num">целое число</param>
    /// <returns>true || false</returns>
    public static bool NatularsCheck(int num)
    {
        if (num < 1) return false;

        else return true;
    }

    /// <summary>
    /// Метод вывода натуральных чисел в промежутке от N до 1
    /// </summary>
    /// <param name="num">целое натуральное число</param>
    public static void NaturalsNumber(int num)
    {
        if (num == 0) return;

        Console.Write($"{num}  ");
        NaturalsNumber(num - 1);
    }

    public static void Main(string[] args)
    {
        int number = GetUserInput("Введите натуральное число: ");

        if(NatularsCheck(number))
        {
            Console.Write($"{number} --> ");
            NaturalsNumber(number);
        }

        else Console.WriteLine("Вы ввели не натурально число!");
    }

}