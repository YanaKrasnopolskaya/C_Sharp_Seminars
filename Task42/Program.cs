// Задача 42: 
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.



int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    
    return num;
}

string BinaryCalc(int num)
{
   string res = string.Empty;

   while (num > 0)
   {
        res = num % 2 + res;
        num /= 2;
   }
   return res;
} 

// int DecimalToBinaryInt(int number, int baseNum)
// {
//     int result = 0;
//     int mult = 1;

//     while (number > 0)                                  // БЕЗ STRING!!!!!
//     {
//         result = (number % baseNum) * mult + result;
//         mult *= 10;
//         number /= baseNum;
//     }
//     return result;
// }

int number = GetUserInput("Введите число в десятичной системе: ");
string result = BinaryCalc(number);
Console.WriteLine($"{number} --> {result}");
