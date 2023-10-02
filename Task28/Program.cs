// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Factorial(int num)
{
    int factorial = 1;
    
    for (int i = 1; i <= num; i++)
    {   
        checked
        {
            factorial *= i;
        }
        
    }
    return factorial;    
}

int number = GetUserInput("Введите целое положительное число: ");
int result = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number}: {result}");