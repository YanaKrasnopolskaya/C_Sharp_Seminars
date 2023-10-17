// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
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
    /// Метод для проверки на положительность числа
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static bool PositiveNumbersCheck(int num)
    {
        if (num < 1) return false;
        else return true;
    }

    public static int MethodAkkermans(int m, int n)
    {
        int result = 0;
        if (m == 0) return result = n + 1;
            
        else if (n == 0) return result = MethodAkkermans(m - 1, 1);
            
        else
            return result = MethodAkkermans(m - 1, MethodAkkermans(m, n - 1));

    }

    public static void Main(string[] args)
    {
        int number1 = GetUserInput("Введите первое целое положительное число M: ");
        int number2 = GetUserInput("Введите второе целое положительное число N: ");

        if (PositiveNumbersCheck(number1) && PositiveNumbersCheck(number2))
        {
            int methodakkermans = MethodAkkermans(number1, number2);
            Console.WriteLine($"Akkerman({number1}, {number2}) = {methodakkermans}");
        }
        else Console.WriteLine("Числа должны быть положительными!");
    }
}