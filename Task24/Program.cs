// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNumbers(int num)
{
    int sum = 0;
    
    for (int i = 1; i <= num; i++)
    {   
        sum += i;
    }
    return sum;    
}

int number = GetUserInput("Введите целое положительное число: ");
int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number}: {result}");