// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if (number1 > number2)
{
    max = number1; 
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.WriteLine($"Большее число: {max}");
Console.WriteLine($"Меньшее число: {min}");
