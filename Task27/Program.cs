// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumDigitInNumber(int num)
{
    int sum = 0;
    int count = Convert.ToString(num).Length;
    for (int i = 0; i < count; i++)
    {
        int res = num % 10;
        sum += res;
        num = num / 10;
    }     
    return sum;
}   


int number = GetUserInput("Enter number: ");
int result = SumDigitInNumber(number);
Console.WriteLine(result);