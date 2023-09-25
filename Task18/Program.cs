// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int GetUserInput(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string RangeCoordinate(int quarterNumber)
{
    if (quarterNumber == 1) return "x > 0 и y > 0";
    if (quarterNumber == 2) return "x < 0 и y > 0";
    if (quarterNumber == 3) return "x < 0 и y < 0";
    if (quarterNumber == 4) return "x > 0 и y < 0";
    return null;
}

int rangecoordinate = GetUserInput("Введите номер четверти: ");
string result = RangeCoordinate(rangecoordinate);
Console.WriteLine($"Диапазон возможных координат точек в этой четверти: {result}");